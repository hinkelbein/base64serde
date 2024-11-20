using System.Text;

var originalString = Console.In.ReadToEnd();
// Convert the string to a byte array (assuming UTF-8 encoding)
var bytes = Encoding.UTF8.GetBytes(originalString);

// Encode the byte array to a Base64 string
var base64EncodedString = Convert.ToBase64String(bytes);

// Output the Base64-encoded string
Console.Write(base64EncodedString);