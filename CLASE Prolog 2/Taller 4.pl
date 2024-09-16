materia('Redes', 2).
materia('Fisica', 3).
materia('Matematicas', 3).
estudiante('Juan', 'Redes').
estudiante('Roberto', 'Matematicas').
estudiante('Gabriel', 'Fisica').

materias_por_estudiante(Estudiante, Materia) :-
    estudiante(Estudiante, Materia).
estudiantes_por_materia(Materia, Estudiante) :-
    estudiante(Estudiante, Materia).
creditos_por_materia(Materia, Creditos) :-
    materia(Materia, Creditos).