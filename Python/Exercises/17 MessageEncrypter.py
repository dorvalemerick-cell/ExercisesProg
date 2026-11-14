import random
import string

chars = " " + string.punctuation + string.digits + string.ascii_letters
chars = list(chars)
key = chars.copy()

random.shuffle(key)

# print(f"{chars}")
# print(f"{key}")

message = input("Enter the text you want to encrypt: ")
encrypted_message = ""

for letters in message:
    index = chars.index(letters)
    encrypted_message += key[index]

print(f"Original message: {message}")
print(f"Encrypted Message: {encrypted_message}")


encrypted_message = input("Enter the text you want to decrypt: ")
decrypted_message = ""
for letters in encrypted_message:
    index = key.index(letters)
    decrypted_message += chars[index]

print(f"Original message: {message}")
print(f"Encrypted Message: {encrypted_message}")