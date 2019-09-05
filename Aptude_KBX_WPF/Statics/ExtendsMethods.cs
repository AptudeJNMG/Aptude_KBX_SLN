using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Aptude_KBX_WPF.Statics
{
    public static class Ext_Mensajes
    {
        public static void Error(string mensaje)
        {
            MessageBox.Show(mensaje, Messages.Error, MessageBoxButton.OK, MessageBoxImage.Error);
        }
        public static void Error(string mensaje, string titulo)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButton.OK, MessageBoxImage.Error);
        }
        public static void Exito(string mensaje)
        {
            MessageBox.Show(mensaje, Messages.Exito, MessageBoxButton.OK, MessageBoxImage.Information);
        }
        public static void Exito(string mensaje, string titulo)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButton.OK, MessageBoxImage.Information);
        }
        public static MessageBoxResult Pregunta(string mensaje)
        {
            return MessageBox.Show(mensaje, Messages.Pregunta, MessageBoxButton.OKCancel, MessageBoxImage.Question);
        }
        public static MessageBoxResult Pregunta(string mensaje, string titulo)
        {
            return MessageBox.Show(mensaje, titulo, MessageBoxButton.OKCancel, MessageBoxImage.Question);
        }
    }

    public static class Ext_File
    {
        internal static void DocumentoUnico(this OpenFileDialog openFile, string filtro, DocType documento)
        {
            openFile.Multiselect = false;
            openFile.InitialDirectory = @"C:\";
            openFile.DefaultExt = documento == DocType.DOCUMENT ? ".doc|.pdf" : ".png|.jpg";
            openFile.Filter = filtro;
            openFile.CheckFileExists = true;
            openFile.CheckPathExists = true;
        }
        public static byte[] ImageSourceToBytes(this Stream imageSource)
        {
            byte[] b;
            using (BinaryReader br = new BinaryReader(imageSource))
            {
                b = br.ReadBytes((int)imageSource.Length);
            }
            return b;
        }
    }
}
