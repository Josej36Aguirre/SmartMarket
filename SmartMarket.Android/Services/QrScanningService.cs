using Xamarin.Forms;

[assembly: Dependency(typeof(SmartMarket.Droid.Services.QrScanningService))]
namespace SmartMarket.Droid.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Android.App;
    using Android.Content;
    using Android.OS;
    using Android.Runtime;
    using Android.Views;
    using Android.Widget;
    using SmartMarket.Services;
    using ZXing.Mobile;
    
    public class QrScanningService : IQrScanningService
    {
        public async Task<string> ScanAsync()
        {
            var optionsDefault = new MobileBarcodeScanningOptions();
            var optionsCustom = new MobileBarcodeScanningOptions();
            var scanner = new MobileBarcodeScanner()
            {
                TopText = "Acerca la camara al código",
                BottomText = "Toca la pantalla para enfocar"
            };
            var scanResult = await scanner.Scan(optionsCustom);
            return scanResult.Text;
        }
    }
}