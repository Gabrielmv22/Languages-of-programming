#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main() {
    int pares = 0, impares = 0;
    int numero;

    srand(time(0));

    for (int i = 0; i < 500; i++) {
        numero = rand() % 51 + 50; 

        if (numero % 2 == 0) {
            pares++;
        } else {
            impares++;
        }
    }

    printf("Valores pares: %d\n", pares);
    printf("Valores impares: %d\n", impares);

    return 0;
}
