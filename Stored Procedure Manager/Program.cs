using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Stored_Procedure_Manager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());



        }

        private static bool init()
        {
            bool success = true;
            Cipher.Key = "121419850404198901072016";
            return success;
        }


        //Nancee Code

        /*private static bool init()
        {
            bool success = true;

            try
            {
                // create resource manager for SierraIntegration assembly
                m_resourceMgr = new ResourceManager("SierraIntegration.SiResources", Assembly.GetExecutingAssembly());

                // path to use for various XML files
                string path = "";

                // get the application data folder 
                string appDataFolder = GetTiaDataFolder();
                if (!Directory.Exists(appDataFolder))
                {
                    // data folder does not exist - need to create it
                    success = createTiaDataFolder();

                    // only upgrade if appdef.xml is present in startup folder
                    if (success && File.Exists(Application.StartupPath + "\\appdef.xml"))
                        success = upgradeTiaAppData();
                }
                if (success)
                {
                    // set up Cipher
                    Cipher.Key = "ShoesShipsAndSealingWax!";

                    // create or read AppDef
                    path = appDataFolder + "\\appdef.xml";
                    if (!File.Exists(path))
                    {
                        AppDefForm appDefForm = new AppDefForm();
                        appDefForm.SupportedAppsOnly = true;
                        if (appDefForm.ShowDialog() == DialogResult.OK)
                        {
                            AppDef appDef = AppDef.Instance;

                            // get the results from the form
                            appDef.AccountingPackage = appDefForm.AccountingPackage;
                            appDef.AccountingPackageName = appDefForm.AccountingPackageName;
                            appDef.TimekeepingPackage = appDefForm.TimekeepingPackage;
                            appDef.TimekeepingPackageName = appDefForm.TimekeepingPackageName;

                            // write it out
                            appDef.Write(path);
                            MessageBox.Show(path + " written", "Successful Generation");

                            // delete config file if present
                            path = appDataFolder + "\\config.xml";
                            if (File.Exists(path))
                                File.Delete(path);
                        }
                        else
                        {
                            string msgCaption = getResourceString("IDS_Caption_Cannot_Start");
                            string msg = getResourceString("IDS_Error_NoAppDef");
                            MessageBox.Show(msg, msgCaption, MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                            success = false;
                        }
                    }
                }
                if (success)
                {
                    // get application definition FIRST
                    AppDef appDef = AppDef.Instance;
                    string appDefPath = appDataFolder + "\\appdef.xml";
                    appDef.Read(appDefPath);

                    // in case the option for multiple company support is in effect,
                    // set the data folder for AppConfig and read it if present
                    AppConfig.Instance.DataFolder = appDataFolder;
                    bool appConfigPresent = AppConfig.Instance.Read();  // returns false if file not found
                    if (appConfigPresent)
                    {
                        if (AppConfig.Instance.MultipleCompanySupport)
                        {
                            if (AppConfig.Instance.CurrentCompany != null)
                            {
                                appDataFolder = AppConfig.Instance.CompanyDataFolder(
                                                    AppConfig.Instance.CurrentCompany.CompanyName);
                                if (!Directory.Exists(appDataFolder) ||
                                    !File.Exists(appDataFolder + "\\config.xml"))
                                {
                                    success = AppConfig.Instance.CreateCompanyDataFolder(appDataFolder);
                                    if (!success)
                                    {
                                        MessageBox.Show(AppConfig.Instance.CompanyErrorMessage,
                                                        "Problem with Company Data Folder",
                                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                            // else setting the company in the combo box will call SwitchCompanies() later
                        }
                        else
                        {
                            // get rid of AppConfig.xml
                            File.Delete(appDataFolder + "\\appconfig.xml");
                        }
                    }
                    if (success)
                    {
                        // tell Logger where to store its file
                        Logger.LogFilePath = appDataFolder;

                        // tell ExceptionForm and ReportForm where the data files are
                        ExceptionForm.DataFolder = appDataFolder;
                        ReportForm.DataFolder = appDataFolder;

                        // create config
                        Config cfg = Config.Instance;

                        // config makes the correct derived config objects
                        //   within it based on AppDef info
                        cfg.Init(appDataFolder);

                        // either read config or write it if missing
                        path = appDataFolder + "\\config.xml";
                        if (File.Exists(path))
                            cfg.Read();
                        else
                            cfg.Write();

                        // AppDef is the master source of package names
                        cfg.AccountingConfig.PackageName = appDef.AccountingPackageName;
                        cfg.TimekeepingConfig.PackageName = appDef.TimekeepingPackageName;
                        cfg.Write();

                        // create payroll factory
                        switch (appDef.AccountingPackage)
                        {
                            case AccountingPackage.DynamicsGP:
                                m_prFactory = new GPPayrollFactory();
                                break;

                            case AccountingPackage.DynamicsGPCan:
                                m_prFactory = new GPCanPayrollFactory();
                                break;

                            case AccountingPackage.DynamicsGPProject:
                                m_prFactory = new GPProjectFactory();
                                break;

                            case AccountingPackage.DynamicsNAV:
                                m_prFactory = new NavPayrollFactory();
                                break;

                            case AccountingPackage.Accpac:
                            case AccountingPackage.AccpacCan:
                                m_prFactory = new AccPayrollFactory();
                                break;

                            case AccountingPackage.BusinessWorks:
                                m_prFactory = new BWPayrollFactory();
                                break;

                            case AccountingPackage.MAS:
                                m_prFactory = new MASPayrollFactory();
                                break;

                            case AccountingPackage.MASPII:
                                m_prFactory = new MASPIIPayrollFactory();
                                break;

                            case AccountingPackage.CreativeSolutions:
                                m_prFactory = new CSPayrollFactory();
                                break;

                            case AccountingPackage.WennSoftCan:
                                m_prFactory = new GPWSCanPayrollFactory();
                                break;

                            case AccountingPackage.WennSoftUS:
                                m_prFactory = new GPWSUSPayrollFactory();
                                break;

                            default:
                                Debug.Assert(false);
                                break;
                        }

                        // create timekeeping factory
                        switch (appDef.TimekeepingPackage)
                        {
                            case TimekeepingPackage.TimeForce:
                                m_tkFactory = new TFTimeKeeperFactory();
                                break;

                            case TimekeepingPackage.TimeForceII:
                                m_tkFactory = new TF2TimeKeeperFactory();
                                break;

                            case TimekeepingPackage.TimeAmericaPro:
                                m_tkFactory = new TAProTimeKeeperFactory();
                                break;

                            case TimekeepingPackage.TimeAmericaSql:
                                m_tkFactory = new TASqlTimeKeeperFactory();
                                break;

                            case TimekeepingPackage.CeleriTime:
                                m_tkFactory = new CTTimeKeeperFactory();
                                break;

                            default:
                                Debug.Assert(false);
                                break;
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                success = false;
                ExceptionForm exForm = new ExceptionForm(ex);
                exForm.Message = "Program initialization: " + ex.Message;
                exForm.ShowDialog();
            }
            catch (ArgumentException ex)
            {
                success = false;
                ExceptionForm exForm = new ExceptionForm(ex);
                exForm.Message = "Program initialization: " + ex.Message;
                exForm.ShowDialog();
                Logger.WriteXml();
            }
            catch (ArithmeticException ex)
            {
                success = false;
                ExceptionForm exForm = new ExceptionForm(ex);
                exForm.Message = "Program initialization: " + ex.Message;
                exForm.ShowDialog();
                Logger.WriteXml();
            }
            catch (OutOfMemoryException ex)
            {
                success = false;
                ExceptionForm exForm = new ExceptionForm(ex);
                exForm.Message = "Program initialization: " + ex.Message;
                exForm.ShowDialog();
                Logger.WriteXml();
            }
            catch (IndexOutOfRangeException ex)
            {
                success = false;
                ExceptionForm exForm = new ExceptionForm(ex);
                exForm.Message = "Program initialization: " + ex.Message;
                exForm.ShowDialog();
                Logger.WriteXml();
            }
            catch (XmlException ex)
            {
                success = false;
                ExceptionForm exForm = new ExceptionForm(ex);
                exForm.Message = "Program initialization: " + ex.Message;
                exForm.ShowDialog();
                Logger.WriteXml();
            }
            catch (CryptographicException ex)
            {
                success = false;
                ExceptionForm exForm = new ExceptionForm(ex);
                exForm.Message = "Program initialization: " + ex.Message;
                exForm.ShowDialog();
                Logger.WriteXml();
            }
            catch (SecurityException ex)
            {
                success = false;
                ExceptionForm exForm = new ExceptionForm(ex);
                exForm.Message = "Program initialization: " + ex.Message;
                exForm.ShowDialog();
                Logger.WriteXml();
            }
            catch (UnauthorizedAccessException ex)
            {
                success = false;
                ExceptionForm exForm = new ExceptionForm(ex);
                exForm.Message = "Program initialization: " + ex.Message;
                exForm.ShowDialog();
                Logger.WriteXml();
            }
            return success;
        }*/


    }
}
