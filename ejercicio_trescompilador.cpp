#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main() {
    int ventas[25];
    char* sucursales[25];
    int suma = 0;
    float promedio;

    for (int i = 0; i < 25; i++) {
        sucursales[i] = "Sucursal";
    }

    srand(time(0));

    for (int i = 0; i < 25; i++) {
        ventas[i] = rand() % 4001 + 1000; 
        suma += ventas[i];
    }

    promedio = suma / 25.0;

    printf("Promedio de ventas: %.2f\n", promedio);

    printf("Sucursales con ventas mayores al promedio:\n");
    for (int i = 0; i < 25; i++) {
        if (ventas[i] > promedio) {
            printf("%s %d: %d\n", sucursales[i], i + 1, ventas[i]);
        }
    }

    return 0;
}
