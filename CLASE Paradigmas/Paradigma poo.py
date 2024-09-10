#Gabriel Miño
#03-09-2024
#---------------------------------------------------------------------------------
#ejemplo paradigna POO

class cuentaBancaria:
    def __init__(self,nombre,saldo):
        self.nomntre=nombre
        self.saldo=saldo
        
    def depositar(self,deposito):
        self.saldo+=deposito
        return self
    
    def retirar(self,retiro):
        if self.saldo>=retiro:
            self.saldo-=retiro
        else:
            raise ValueError("Fondos insuficientes")
        
    def __str__(self):
        return f"Cuenta: {self.nomntre} Saldo: {self.saldo}"
    
Cuenta_1=cuentaBancaria("Gabriel",1000)
Cuenta_2=cuentaBancaria("Cynthia",2300)
Cuenta_3=cuentaBancaria("Cristian",38000)

print(Cuenta_1)
print(Cuenta_2)
print(Cuenta_3)
Cuenta_3.depositar(320)
Cuenta_2.depositar(1000)
Cuenta_1.depositar(2000)
print(Cuenta_1)
print(Cuenta_2)
print(Cuenta_3)
Cuenta_3.retirar(320)
Cuenta_2.retirar(2300)
Cuenta_1.retirar(2000)
print(Cuenta_1)
print(Cuenta_2)
print(Cuenta_3) 
print("terminal")