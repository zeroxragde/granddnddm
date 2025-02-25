using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GranDnDDM.Tools
{
    public class CursorHelper
    {
        [StructLayout(LayoutKind.Sequential)]
        private struct ICONINFO
        {
            public bool fIcon;      // true para icono, false para cursor
            public int xHotspot;    // coordenada X del punto activo
            public int yHotspot;    // coordenada Y del punto activo
            public IntPtr hbmMask;  // bitmap de máscara
            public IntPtr hbmColor; // bitmap de color
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr CreateIconIndirect(ref ICONINFO iconInfo);

        [DllImport("gdi32.dll")]
        private static extern bool DeleteObject(IntPtr hObject);

        /// <summary>
        /// Crea un Cursor desde un Bitmap usando CreateIconIndirect.
        /// </summary>
        /// <param name="bmp">El bitmap con la imagen del cursor.</param>
        /// <param name="hotX">Posición X del punto activo.</param>
        /// <param name="hotY">Posición Y del punto activo.</param>
        /// <returns>Cursor creado.</returns>
        public static Cursor CreateCursorFromBitmap(Bitmap bmp, int hotX, int hotY)
        {
            if (bmp == null) throw new ArgumentNullException(nameof(bmp));

            // Creamos dos HBITMAP: uno para la máscara y otro para el color
            IntPtr hbmMask = bmp.GetHbitmap();
            IntPtr hbmColor = bmp.GetHbitmap();

            var iconInfo = new ICONINFO
            {
                fIcon = false, // false => cursor
                xHotspot = hotX,
                yHotspot = hotY,
                hbmMask = hbmMask,
                hbmColor = hbmColor
            };

            IntPtr hCursor = CreateIconIndirect(ref iconInfo);
            if (hCursor == IntPtr.Zero)
            {
                // Liberamos recursos antes de lanzar la excepción
                DeleteObject(hbmMask);
                DeleteObject(hbmColor);
                throw new Win32Exception("No se pudo crear el cursor desde el bitmap.");
            }

            // Liberamos los bitmaps GDI
            DeleteObject(hbmMask);
            DeleteObject(hbmColor);

            return new Cursor(hCursor);
        }
    }
}
