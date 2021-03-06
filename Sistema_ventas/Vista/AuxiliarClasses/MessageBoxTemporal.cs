﻿using System;
using System.Windows.Forms;
using Modelo;

namespace Vista
{
    public class MessageBoxTemporal
    {
        System.Threading.Timer IntervaloTiempo;
        string TituloMessageBox;
        int TiempoMaximo;
        IntPtr hndLabel = IntPtr.Zero;
        bool MostrarContador;

        MessageBoxTemporal(Usuario user, string titulo, int tiempo, bool contador)
        {
            TituloMessageBox = titulo;
            TiempoMaximo = tiempo;
            MostrarContador = contador;

            if (TiempoMaximo > 9) return; //Máximo 9 segundos
                IntervaloTiempo = new System.Threading.Timer(EjecutaCada1Segundo,
                    null, 1000, 1000);
            if (contador)
            {
                //DialogResult ResultadoMensaje = MessageBox.Show(texto + "\r\nEste mensaje se cerrará dentro de " +
                    //TiempoMaximo.ToString("00") + " segundos ...", titulo);
                DialogResult ResultadoMensaje = MessageBox.Show("¡Bienvenido (a):" + Environment.NewLine + user.Paterno.ToUpper() + " " +
                    user.Materno.ToUpper() + ", " + user.Nombre, titulo);
                if (ResultadoMensaje == DialogResult.OK) IntervaloTiempo.Dispose();
            }
            else
            {
                DialogResult ResultadoMensaje = MessageBox.Show("¡Bienvenido (a) " + "...", titulo);
                if (ResultadoMensaje == DialogResult.OK) IntervaloTiempo.Dispose();
            }
        }
        public static void Show(Usuario user, string titulo, int tiempo, bool contador)
        {
            new MessageBoxTemporal(user, titulo, tiempo, contador);
        }
        void EjecutaCada1Segundo(object state)
        {
            TiempoMaximo--;
            if (TiempoMaximo <= 0)
            {
                IntPtr hndMBox = FindWindow(null, TituloMessageBox);
                if (hndMBox != IntPtr.Zero)
                {
                    SendMessage(hndMBox, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
                    IntervaloTiempo.Dispose();
                }
            }
            else if (MostrarContador)
            {
                // Ha pasado un intervalo de 1 seg:
                if (hndLabel != IntPtr.Zero)
                {
                    //SetWindowText(hndLabel, TextoMessageBox +
                     //   "\r\nEste mensaje se cerrará dentro de " +
                        //TiempoMaximo.ToString("00") + " segundos");
                }
                else
                {
                    IntPtr hndMBox = FindWindow(null, TituloMessageBox);
                    if (hndMBox != IntPtr.Zero)
                    {
                        // Ha encontrado el MessageBox, busca ahora el texto
                        hndLabel = FindWindowEx(hndMBox, IntPtr.Zero, "Static", null);
                        if (hndLabel != IntPtr.Zero)
                        {
                            // Ha encontrado el texto porque el MessageBox
                            // solo tiene un control "Static".
                            //SetWindowText(hndLabel, TextoMessageBox +
                             //   "\r\nEste mensaje se cerrará dentro de " +
                              //  TiempoMaximo.ToString("00") + " segundos");
                        }
                    }
                }
            }
        }
        const int WM_CLOSE = 0x0010;
        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [System.Runtime.InteropServices.DllImport("user32.dll",
            CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true,
            CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter,
            string lpszClass, string lpszWindow);
        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true,
            CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        static extern bool SetWindowText(IntPtr hwnd, string lpString);
    }
}
