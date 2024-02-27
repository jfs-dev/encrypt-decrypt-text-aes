# encrypt-decrypt-text-aes
Usando o algoritmo AES (Advanced Encryption Standard) para criptografar e descriptografar textos de forma segura em C#

![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)
![Visual Studio Code](https://img.shields.io/badge/Visual%20Studio%20Code-0078d7.svg?style=for-the-badge&logo=visual-studio-code&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91.svg?style=for-the-badge&logo=visual-studio&logoColor=white)

## Sobre o projeto
Este projeto mostra como usar o algoritmo AES (Advanced Encryption Standard) para criptografar e descriptografar textos de forma segura em C#.

O AES (Advanced Encryption Standard) é um algoritmo de criptografia simétrica amplamente utilizado para proteger dados.

O AES opera por meio de cifra de bloco, o que significa que ele opera em blocos fixos de dados, geralmente de 128 bits, e aplica transformações repetidas para criptografar ou descriptografar os dados. O algoritmo oferece diferentes tamanhos de chave, sendo 128, 192 e 256 bits, proporcionando diferentes níveis de segurança.

O AES é amplamente utilizado em uma variedade de aplicativos, incluindo comunicações seguras na internet, armazenamento de dados protegidos e criptografia de arquivos. Ele é considerado um dos algoritmos de criptografia mais seguros e eficientes disponíveis atualmente.

**AES-128 (chave de 128 bits):** A chave deve ter 16 bytes (128 bits).
Por exemplo, uma chave hexadecimal de 16 caracteres: <code>0123456789ABCDEF</code>.

**AES-192 (chave de 192 bits):** A chave deve ter 24 bytes (192 bits).
Por exemplo, uma chave hexadecimal de 24 caracteres: <code>0123456789ABCDEF01234567</code>.

**AES-256 (chave de 256 bits):** A chave deve ter 32 bytes (256 bits).
Por exemplo, uma chave hexadecimal de 32 caracteres: <code>0123456789ABCDEF0123456789ABCDEF</code>.

Nos algoritmos de criptografia simétrica, como o AES (Advanced Encryption Standard), a mesma chave é usada tanto para criptografar quanto para descriptografar os dados. O vetor de inicialização (IV), por outro lado, é um valor adicional que é usado juntamente com a chave para aumentar a segurança da criptografia.

<div align="center">
    <img src="https://github.com/jfs-dev/encrypt-decrypt-text-aes/assets/54154628/fe0dbb24-947c-4027-93dd-f5f26f65f378"</img>
</div>

## Referências
https://learn.microsoft.com/en-us/dotnet/api/system.security.cryptography.aes?view=net-8.0

## Licença
GPL-3.0 license
