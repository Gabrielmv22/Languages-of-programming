par(X) :- X mod 2 =:= 0.

tiene(juan,bicicleta).
tiene(juan,coche).
tiene(ana,bicicleta).
tiene(ana,moto).
tiene(pedro,moto).

cuadrado(X,R):- R is X*X.

media(A,B,M):- M is (A+B)/2.

factorial(0,1).
factorial(N,R):-
    	N1 is N -1,
    	factorial(N1,R1),
    	R is N*R1.