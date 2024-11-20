using System.Text;

string base64EncodedString = Console.In.ReadToEnd();

// Decode the Base64 string to a byte array
byte[] decodedBytes = Convert.FromBase64String(base64EncodedString);

// Convert the byte array to a string (assuming UTF-8 encoding)
string decodedString = Encoding.UTF8.GetString(decodedBytes);

// Output the decoded string
Console.Write(decodedString);