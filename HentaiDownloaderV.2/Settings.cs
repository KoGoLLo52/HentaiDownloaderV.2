using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HentaiDownloaderV._2.Properties
{
    internal sealed partial class Settings
    {
        public Settings()
        {
            // Para agregar los controladores de eventos para guardar y cambiar la configuración, quite la marca de comentario de las líneas:
            //
            // this.SettingChanging += this.SettingChangingEventHandler;
            //
            // this.SettingsSaving += this.SettingsSavingEventHandler;
            //
        }

        private void SettingChangingEventHandler(object sender, System.Configuration.SettingChangingEventArgs e)
        {
            // Agregar código para administrar aquí el evento SettingChangingEvent.
        }

        private void SettingsSavingEventHandler(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Agregar código para administrar aquí el evento SettingsSaving.
        }
    }
}
