// Copyright (C) Sierra Computer Solutions. All rights reserved.

// Original code came from:
// http://www.codeproject.com/KB/cs/Cryptography.aspx

// class Cipher
// Encrypts and decrypts strings with class methods (static).
//
// Encrypt method: Encrypts a string into another string, 
// i.e. all characaters in the encrypted result are printable.
// The algorithm used is Triple DES.
//
// Decrypt method: Decrypts a string encrypted with the
// same key.
//
// Added the ability to encrypt/decrypt an element in an XML document.
// That code came from Microsoft (with some tweaking): 
// http://msdn.microsoft.com/en-us/library/sb7w85t6.aspx
//
// Those methods are:
//
// EncryptXml method: Encrypts the specified element (by tag name) in
// the XML document passed in. Indicate which occurrence of the
// element with an index formal parameter (0 = first occurrence).
//
// DecryptXml method: Decrypts an encrypted element in the XML
// document passed in. The encrypted element is called
// "EncryptedData". Indicate which occurrence of EncryptedData
// element with an index formal paramter (0 = first occurrence).
//
// Note: NLT added the elementIndex parameter to make it more flexible.
// The Microsoft code used [0] where [elementIndex] is now used.
//
// Provides a property to set the key. The key MUST be 24 characters.

using System;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
using System.Security.Cryptography.Xml;

namespace Stored_Procedure_Manager
{
    public sealed class Cipher
    {
        // key must be exactly 24 characters
        static string m_key = "123456789012345678901234";

        // private ctor to keep the compiler from creating a public default ctor
        // static classes have no need for a constructor
        private Cipher() { }

        public static string Encrypt(string toEncrypt)
        {
            return doEncrypt(toEncrypt, false);
        }

        public static string Decrypt(string value)
        {
            return doDecrypt(value, false);
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage(
            "Microsoft.Design",
            "CA1059:MembersShouldNotExposeCertainConcreteTypes",
            Justification = "Concrete type XmlDocument is needed to have access to GetElementsByTagName() " +
            "and IXPathNavigable does not provide that."
        )]
        public static void EncryptXml(XmlDocument xmlDoc, string elementName, int elementIndex)
        {
            doEncryptXml(xmlDoc, elementName, elementIndex);
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage(
            "Microsoft.Design",
            "CA1059:MembersShouldNotExposeCertainConcreteTypes",
            Justification = "Concrete type XmlDocument is needed to have access to GetElementsByTagName() " +
            "and IXPathNavigable does not provide that."
        )]
        public static void DecryptXml(XmlDocument xmlDoc, int elementIndex)
        {
            doDecryptXml(xmlDoc, elementIndex);
        }

        public static string Key
        {
            get { return m_key; }
            set
            {
                if (value.Length == 24)
                {
                    m_key = value;
                }
                else
                {
                    // throw an exception
                    //SIException ex = new SIException("Cipher key must be 24 characters exactly");
                    //throw ex;
                    
                }
            }
        }

        //=== PRIVATE FUNCTIONS BELOW ===

        private static string doEncrypt(string toEncrypt, bool useHashing)
        {
            byte[] keyArray;
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);

            string key = m_key;

            //System.Windows.Forms.MessageBox.Show(key);
            //If hashing use get hashcode regards to your key
            if (useHashing)
            {
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                //Always release the resources and flush data
                // of the Cryptographic service provide. Best Practice

                hashmd5.Clear();
            }
            else
                keyArray = UTF8Encoding.UTF8.GetBytes(key);

            TripleDESCryptoServiceProvider tdes =
                     new TripleDESCryptoServiceProvider();

            //set the secret key for the tripleDES algorithm
            tdes.Key = keyArray;

            //mode of operation. there are other 4 modes.
            //We choose ECB(Electronic code Book)
            tdes.Mode = CipherMode.ECB;

            //padding mode(if any extra byte added)
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateEncryptor();

            //transform the specified region of bytes array to resultArray
            byte[] resultArray =
              cTransform.TransformFinalBlock(toEncryptArray, 0,
              toEncryptArray.Length);

            //Release resources held by TripleDes Encryptor
            tdes.Clear();

            //Return the encrypted data into unreadable string format
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        private static string doDecrypt(string cipherString, bool useHashing)
        {
            byte[] keyArray;
            //get the byte code of the string

            byte[] toEncryptArray = Convert.FromBase64String(cipherString);

            string key = m_key;

            if (useHashing)
            {
                //if hashing was used get the hash code with regards to your key
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                //release any resource held by the MD5CryptoServiceProvider

                hashmd5.Clear();
            }
            else
            {
                //if hashing was not implemented get the byte code of the key
                keyArray = UTF8Encoding.UTF8.GetBytes(key);
            }

            TripleDESCryptoServiceProvider tdes =
                        new TripleDESCryptoServiceProvider();
            //set the secret key for the tripleDES algorithm
            tdes.Key = keyArray;

            //mode of operation. there are other 4 modes. 
            //We choose ECB(Electronic code Book)
            tdes.Mode = CipherMode.ECB;

            //padding mode(if any extra byte added)
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(
                                 toEncryptArray, 0, toEncryptArray.Length);

            //Release resources held by TripleDes Encryptor                
            tdes.Clear();

            //return the Clear decrypted TEXT
            return UTF8Encoding.UTF8.GetString(resultArray);
        }

        // The elementName is the tag name for the element.
        // The elementIndex is the occurrence of the tag (minus 1).
        private static void doEncryptXml(XmlDocument xmlDoc, string elementName,
                                         int elementIndex)
        {
            // Check the arguments.  
            if (xmlDoc == null)
                throw new ArgumentNullException("xmlDoc");
            if (elementName == null)
                throw new ArgumentNullException("elementName");

            ////////////////////////////////////////////////
            // Find the specified element in the XmlDocument
            // object and create a new XmlElement object.
            ////////////////////////////////////////////////
            XmlElement elementToEncrypt = xmlDoc.GetElementsByTagName(elementName)[elementIndex]
                                            as XmlElement;
            // Throw an XmlException if the element was not found.
            if (elementToEncrypt == null)
            {
                throw new XmlException("The specified element was not found");
            }

            ////////////////////////////////////////////////
            // Set up the algorithm
            ////////////////////////////////////////////////
            string key = m_key;
            byte[] keyArray;
            keyArray = UTF8Encoding.UTF8.GetBytes(key);

            TripleDESCryptoServiceProvider tdes =
                     new TripleDESCryptoServiceProvider();

            //set the secret key for the tripleDES algorithm
            tdes.Key = keyArray;

            //mode of operation. there are other 4 modes.
            //We choose ECB(Electronic code Book)
            tdes.Mode = CipherMode.ECB;

            //padding mode(if any extra byte added)
            tdes.Padding = PaddingMode.PKCS7;

            //////////////////////////////////////////////////
            // Create a new instance of the EncryptedXml class 
            // and use it to encrypt the XmlElement with the 
            // symmetric key. 
            // The false argument means encrypt the entire
            // element; true means to encrypt just the content.
            //////////////////////////////////////////////////
            EncryptedXml eXml = new EncryptedXml();
            byte[] encryptedElement = eXml.EncryptData(elementToEncrypt, tdes, false);

            ////////////////////////////////////////////////
            // Construct an EncryptedData object and populate
            // it with the desired encryption information.
            ////////////////////////////////////////////////

            EncryptedData edElement = new EncryptedData();
            edElement.Type = EncryptedXml.XmlEncElementUrl;

            // Create an EncryptionMethod element so that the 
            // receiver knows which algorithm to use for decryption.
            // Determine what kind of algorithm is being used and
            // supply the appropriate URL to the EncryptionMethod element.
            // NLT modified the original code to just use Triple DES.

            string encryptionMethod = EncryptedXml.XmlEncTripleDESUrl;
            edElement.EncryptionMethod = new EncryptionMethod(encryptionMethod);

            // Add the encrypted element data to the 
            // EncryptedData object.
            edElement.CipherData.CipherValue = encryptedElement;

            ////////////////////////////////////////////////////
            // Replace the element from the original XmlDocument
            // object with the EncryptedData element.
            ////////////////////////////////////////////////////
            EncryptedXml.ReplaceElement(elementToEncrypt, edElement, false);
        }

        private static void doDecryptXml(XmlDocument xmlDoc, int elementIndex)
        {
            // Check the arguments.  
            if (xmlDoc == null)
                throw new ArgumentNullException("xmlDoc");

            // Find the EncryptedData element in the XmlDocument.
            XmlElement encryptedElement = xmlDoc.GetElementsByTagName("EncryptedData")[elementIndex]
                                            as XmlElement;

            // If the EncryptedData element was not found, throw an exception.
            if (encryptedElement == null)
            {
                throw new XmlException("The EncryptedData element was not found.");
            }

            ////////////////////////////////////////////////
            // Set up the algorithm
            ////////////////////////////////////////////////
            string key = m_key;
            byte[] keyArray;
            keyArray = UTF8Encoding.UTF8.GetBytes(key);

            TripleDESCryptoServiceProvider tdes =
                     new TripleDESCryptoServiceProvider();

            //set the secret key for the tripleDES algorithm
            tdes.Key = keyArray;

            //mode of operation. there are other 4 modes.
            //We choose ECB(Electronic code Book)
            tdes.Mode = CipherMode.ECB;

            //padding mode(if any extra byte added)
            tdes.Padding = PaddingMode.PKCS7;

            ////////////////////////////////////////////////
            // Decrypt
            ////////////////////////////////////////////////

            // Create an EncryptedData object and populate it.
            EncryptedData edElement = new EncryptedData();
            edElement.LoadXml(encryptedElement);

            // Create a new EncryptedXml object.
            EncryptedXml exml = new EncryptedXml();

            // Decrypt the element using the symmetric key.
            byte[] rgbOutput = exml.DecryptData(edElement, tdes);

            // Replace the encryptedData element with the plain text XML element.
            exml.ReplaceData(encryptedElement, rgbOutput);
        }
    }
}
