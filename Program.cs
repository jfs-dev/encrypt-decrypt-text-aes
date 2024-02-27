using encrypt_decrypt_text_aes.Services;

string keyString = "SecretKey1234567";
string ivString = "SecretIV12345676";

CryptographyService cryptographyService = new (keyString, ivString);

string originalText = "Esta é uma mensagem secreta que será criptografada.";

byte[] encryptedText = cryptographyService.Encrypt(originalText);

string decryptedText = cryptographyService.Decrypt(encryptedText);

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($"Texto original: {originalText}");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Texto criptografado: {Convert.ToBase64String(encryptedText)}");

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"Texto descriptografado: {decryptedText}");