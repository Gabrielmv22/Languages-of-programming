import random
sucursales = [f"Sucursal {i+1}" for i in range(25)]
ventas = [random.randint(1000, 5000) for _ in range(25)]

promedio_ventas = sum(ventas) / len(ventas)
sucursales_mayores_promedio = []

for i in range(len(ventas)):
    if ventas[i] > promedio_ventas:
        sucursales_mayores_promedio.append(sucursales[i])

print(f"Promedio de ventas: {promedio_ventas}")
print("Sucursales con ventas mayores al promedio:")
for sucursal in sucursales_mayores_promedio:
    print(sucursal)
