using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace MasterPassword
{
    [Serializable]
    class PasswordsFile
    {
        public string MasterPassword { get; set; }

        public List<Password> Passwords { get; set; }

        /// <summary>
        /// Load File From Specific Path
        /// </summary>
        /// <param name="path">Location Of File</param>
        /// <returns>Passwords File</returns>
        public static PasswordsFile Load(string path)
        {
            PasswordsFile file = new PasswordsFile();
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None);
            BinaryFormatter Bf = new BinaryFormatter();
            
            if (File.Exists(path))
                file = (PasswordsFile)Bf.Deserialize(fs);
            else
                throw new FileNotFoundException();
            fs.Close();
            return file;

        }


        /// <summary>
        /// Save Current Passwords And Master Password File in Specific Path.
        /// </summary>
        /// <param name="path">File Location To Save.</param>
        public void Save(string path)
        {
            PasswordsFile file = new PasswordsFile();
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
            BinaryFormatter Bf = new BinaryFormatter();
            Bf.Serialize(fs, this);
            fs.Close();
        }
    }
}
