using System;
using System.Collections.Generic;
using System.Text;

namespace DemoAES
{
    class Cryptographer
    {
        ProcessAES cProcess = null;

        public Cryptographer(MainForm.ViewEventHandler _view,MainForm.EndThreadEventHandler _end)
        {
            cProcess = new ProcessAES(_view, _end);
        }

        #region Encryption
        public void EncryptionStart(string filename, string EncryptedFilename, string key)
        {
            string binarytext = FileIO.FileReadToBinary(filename);
            binarytext = this.EncryptionStart(binarytext, key, true);
            FileIO.WriteBinaryToFile(EncryptedFilename, binarytext);
        }
        public string EncryptionStart(string text, string key, bool IsBinary)
        {
            return cProcess.EncryptionStart(text, key, IsBinary);
        }
        #endregion

        #region Decryption
        public void DecryptionStart(string filename, string DecryptedFilename, string key)
        {
            string binarytext = FileIO.FileReadToBinary(filename);
            binarytext = this.DecryptionStart(binarytext, key, true);
            FileIO.WriteBinaryToFile(DecryptedFilename, binarytext);
        }
        public string DecryptionStart(string text, string key, bool IsBinary)
        {
            return cProcess.DecryptionStart(text, key, IsBinary);
        }
        #endregion
    }
}
