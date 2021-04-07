# TXTextControlTrial
Testing out TXTextControl Document Viewer

To get this demo ready to test, run 'yarn' in the ClientApp folder.
Once the dependencies are installed, run a normal debug session from Visual Studio.

The issue encountered is a security bug with BinaryFormatter where the platform breaks on

System.NotSupportedException: BinaryFormatter serialization and deserialization are disabled within this application. See https://aka.ms/binaryformatter for more information.
         at System.Runtime.Serialization.Formatters.Binary.BinaryFormatter.Deserialize(Stream serializationStream)
         at System.ComponentModel.Design.DesigntimeLicenseContextSerializer.Deserialize(Stream o, String cryptoKey, RuntimeLicenseContext context)
         at System.ComponentModel.Design.RuntimeLicenseContext.GetSavedLicenseKey(Type type, Assembly resourceAssembly)
         at ?.?.GetLicense(LicenseContext context, Type type, Object instance, Boolean allowExceptions)
         at System.ComponentModel.LicenseManager.ValidateInternalRecursive(LicenseContext context, Type type, Object instance, Boolean allowExceptions, License& license, String& licenseKey)
         at System.ComponentModel.LicenseManager.Validate(Type type, Object instance)
         at TXTextControl.ServerTextControl..ctor(Type controlType)
         at TXTextControl.Web.MVC.DocumentViewer.TextControlHelpers.InitialDocumentCheck(String Document, String SignatureBoxName)
         at TXTextControl.Web.MVC.DocumentViewer.TextControlController.GetHtml(String access_token)
