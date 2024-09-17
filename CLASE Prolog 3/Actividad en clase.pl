tiempo(pasado).
tiempo(presente).
tiempo(futuro).

persona(primera).
persona(segunda).
persona(tercera).

numero(singular).
numero(plural).

% conjugacion para verbo "to be"

ser(presente,primera,singular,"am").
ser(presente,segunda,singular,"are").
ser(presente,tercera,singular,"is").
ser(presente,primera,plural,"are").
ser(presente,segunda,plural,"are").
ser(presente,tercera,plural,"are").

ser(pasado,primera,singular,"was").
ser(pasado,segunda,singular,"were").
ser(pasado,tercera,singular,"was").
ser(pasado,primera,plural,"were").
ser(pasado,segunda,plural,"were").
ser(pasado,tercera,plural,"were").

ser(futuro,primera,singular,"will be").
ser(futuro,segunda,singular,"will be").
ser(futuro,tercera,singular,"will be").
ser(futuro,primera,plural,"will be").
ser(futuro,segunda,plural,"will be").
ser(futuro,tercera,plural,"will be").

% conjugacion para verbo "play"

ser(presente,primera,singular,"play").
ser(presente,segunda,singular,"play").
ser(presente,tercera,singular,"plays").
ser(presente,primera,plural,"play").
ser(presente,segunda,plural,"play").
ser(presente,tercera,plural,"play").

ser(pasado,primera,singular,"played").
ser(pasado,segunda,singular,"played").
ser(pasado,tercera,singular,"played").
ser(pasado,primera,plural,"played").
ser(pasado,segunda,plural,"played").
ser(pasado,tercera,plural,"played").

ser(futuro,primera,singular,"will play").
ser(futuro,segunda,singular,"will play").
ser(futuro,tercera,singular,"will play").
ser(futuro,primera,plural,"will play").
ser(futuro,segunda,plural,"will play").
ser(futuro,tercera,plural,"will play").

conjugar_verbo(Verbo,Tiempo,Persona,Numero,Conjugacion):-
    tiempo(Tiempo),
    persona(Persona),
    numero(Numero),
    (   Verbo="to be"->  
    		ser(Tiempo,Persona,Numero,R),
    		Conjugacion=R;
        Verbo="play"->  
    		ser(Tiempo,Persona,Numero,R),
    		Conjugacion=R;
        conjugacion="no se reconoce el verbo"
    ).

?- conjugar_verbo("to be",pasado,tercera,plural,R)
?- conjugar_verbo("to be",pasado,segunda,plural,R)
?- conjugar_verbo("to be",pasado,primera,plural,R)
?- conjugar_verbo("to be",presente,primera,plural,R)
?- conjugar_verbo("to be",presente,segunda,plural,R)
?- conjugar_verbo("to be",presente,tercera,plural,R)
?- conjugar_verbo("to be",futuro,primera,singular,R)
?- conjugar_verbo("to be",futuro,tercera,plural,R)
?- conjugar_verbo("to be",futuro,segunda,plural,R)

?- conjugar_verbo("play",pasado,tercera,singular,R)
?- conjugar_verbo("play",pasado,segunda,singular,R)
?- conjugar_verbo("play",pasado,primera,singular,R)
?- conjugar_verbo("play",presente,primera,plural,R)
?- conjugar_verbo("play",presente,segunda,plural,R)
?- conjugar_verbo("play",presente,tercera,plural,R)
?- conjugar_verbo("play",futuro,primera,plural,R)
?- conjugar_verbo("play",futuro,tercera,plural,R)
?- conjugar_verbo("play",futuro,segunda,plural,R)
