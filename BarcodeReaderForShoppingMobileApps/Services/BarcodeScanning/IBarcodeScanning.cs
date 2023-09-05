using BarcodeReaderForShoppingMobileApps.BarcodeScanning.Models;

namespace BarcodeReaderForShoppingMobileApps.BarcodeScanning;

public interface IBarcodeScanning
{
    public string ProcessBarcode();
    public ScannedItem GetItem();
}