import random
valores_pares = 0
valores_impares = 0

for i in range(500):
    numero = random.randint(50, 100)
    if numero % 2 == 0:
        valores_pares += 1
    else:
        valores_impares += 1

print(f"Valores pares: {valores_pares}")
print(f"Valores impares: {valores_impares}")
