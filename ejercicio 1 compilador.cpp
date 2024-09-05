#include <stdio.h>

int main() {
    int valores[10];
    int suma = 0;
    float promedio;

    for (int i = 0; i < 10; i++) {
        printf("Ingresa un valor: ");
        scanf("%d", &valores[i]);
        suma += valores[i];
    }

    promedio = suma / 10.0;

    printf("Suma: %d\n", suma);
    printf("Promedio: %.2f\n", promedio);

    return 0;
}
