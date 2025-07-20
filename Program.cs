// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// IRON Barcode Script to read barcode into a string variable

var myBarcode = BarcodeReader.Read(@"");  //image file path

foreach (var item in myBarcode)
{
    Console.WriteLine(item.ToString());
}



//  Code from BarCodeLookUp.com


//Request URL example with BarCode string already found
// var LookUpResult = https://api.barcodelookup.com/v3/products?barcode=3614272049529&formatted=y&key=your_api_key


//Response body of IRL request is a JSON Object, Key:value pair

