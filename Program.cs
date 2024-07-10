//METODOS MAS USADOS EN LINQ

// 1. METODO ANY: PARA VERIFICAR SI HAY ALGÚN NÚMERO QUE CUMPLA CON UN TIPO DE CARACTERISITICA( EJM: HAY NÚMEROS NEGATIVOS EN LA LISTA?)

// var numeros = new List<int> () {-2, -1, 0, 1, 2, 3, 4, 5, 6};

// // Verificar si hay algún número menor que cero en la lista de números
// var hayNumeroNegativo = numeros.Any(n => n < 0);

// Console.WriteLine($"Hay algún número menor que cero: {hayNumeroNegativo}");

// // 2. METODO FIRSTORDEFAULT: NOS TREAE EL PRIMER NÚMERO DEFINIDO DE LA LISTA, EN ESTE CASO EL NUMERO 4

// var first = numeros.IndexOf(numeros.FirstOrDefault(num => num == 4));
// Console.WriteLine(first);

// // 3. METODO MAX: NOS TRAE EL NÚMERO MAXIMO DE UNA LISTA

// var maximo = numeros.Max();
// Console.WriteLine(maximo);

// // 4. METODO PARA CALCULAR EL PROMEDIO DE LAS NOTAS( METODO AVERAGE) y MATH.ROUND  REDONDEA AL ENTERO PROXIMO

// List<double> notas = new List<double>(){1.2, 1.5, 3.4, 4.2};

// double promedio = notas.Average( nota => nota);

// Console.WriteLine(Math.Round(promedio,2)); //despues de la coma pongo 2 y me redondea con 2 números decimales

// 5. METODO WHERE: NOS ARROJA TODOS LOS NUMEROS O ELEMENTOS QUE CUMPLAN CON DETERMINADA CARACTERISTICA

// List<int> numbers = new List<int>(){1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};

// var numeroMayor = numbers.Where(item => item >6).ToList(); //con el TOLIST convertimos todos los número que se extrajeron en otra lista diferente

// Console.WriteLine(numeroMayor.GetType().Name);


// EJERCICIOS PARA PRACTICAR

// 1. Filtra los números mayores a 10 en una lista de enteros.

List<int> numbers = new List<int>(){-3,-2,-1,0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};

// var mayoresA10 = numbers.Where(item => item >10).ToList();
// foreach (var numeroMayor in mayoresA10)
// {
//     Console.WriteLine(numeroMayor);
// }

// 2. Obtén una lista con los cuadrados de cada número en una lista de enteros.

// var cuadrados = numbers.Select(num => num * num).ToList();
// foreach (var cuadrado in cuadrados)
// {
//     Console.WriteLine(cuadrado);
// }

// 3. Ordena alfabéticamente una lista de nombres.

List<string> nombres = new List<string>(){"david", "simon", "jhonatan", "arlex", "daniela", "camila"};

// var nombresOrdenados = nombres.OrderBy( nombre => nombre);
// foreach (var nombre in nombresOrdenados)
// {
//     Console.WriteLine(nombre);
// }


// 4. Ordena una lista de precios de mayor a menor.

List<int> precios = new List<int>(){2200,3500,8100,6400,7650};
// var preciosOrdenados = precios.OrderByDescending(precio => precio).ToList();
// foreach (var precio in preciosOrdenados)
// {
//     Console.WriteLine(precio);
// }

// 5. Encuentra el primer número par en una lista de enteros.

// var primerPar = numbers.First(number => number % 2 == 0 && number > 0);

// Console.WriteLine(primerPar);


// 6. Encuentra el último nombre en una lista de nombres.

// var ultimoNombre = nombres.Last();

// Console.WriteLine(ultimoNombre);


// 7. Obtén el primer número negativo en una lista de enteros, o un valor por defecto si no hay
// ninguno.

var primerNegativo = numbers.FirstOrDefault(num => num < 0);

// 8. Encuentra el último número mayor a 50 en una lista de enteros, o un valor por defecto si
// no hay ninguno.
// 9. Verifica si algún elemento en una lista de booleanos es verdadero.
// 10. Verifica si todos los elementos en una lista de números son mayores a 0.
// 11. Comprueba si una lista de palabras contiene la palabra "LINQ".
// 12. Cuenta cuántos números pares hay en una lista de enteros.
// 13. Calcula la suma de los elementos en una lista de precios.
// 14. Calcula el promedio de una lista de edades.
// 15. Encuentra el número mínimo en una lista de temperaturas.
// 16. Encuentra el número máximo en una lista de alturas.
// 17. Obtén los primeros 5 elementos de una lista de puntuaciones.
// 18. Salta los primeros 3 elementos de una lista de nombres y obtén los siguientes.
// 19. Elimina los elementos duplicados en una lista de números.
// 20. Convierte una lista de palabras en una lista.
// 21. Convierte una lista de números en un array.
// 22. Filtra los números negativos de una lista y ordénalos de menor a mayor.
// 23. Obtén una lista de longitudes de cada palabra en una lista de palabras.
// 24. Ordena una lista de salarios de menor a mayor y obtén los 3 más bajos.
// 25. Obtén los nombres más largos en una lista de nombres.
// 26. Encuentra el primer número mayor a 100 en una lista de precios.
// 27. Encuentra el último día del mes en una lista de fechas.
// 28. Obtén el primer nombre que empieza con 'A' en una lista de nombres o un valor por
// defecto si no hay ninguno.
// 29. Encuentra el último número impar en una lista de enteros o un valor por defecto si no hay
// ninguno.
// 30. Verifica si alguna palabra en una lista de palabras tiene más de 10 caracteres.
// 31. Verifica si todas las edades en una lista son mayores de 18.
// 32. Comprueba si una lista de ciudades contiene la ciudad "Madrid".
// 33. Cuenta cuántos números mayores a 50 hay en una lista de puntuaciones.
// 34. Calcula la suma de los números positivos en una lista de enteros.
// 35. Calcula el promedio de las calificaciones en una lista de calificaciones.
// 36. Encuentra la temperatura mínima en una lista de temperaturas.
// 37. Encuentra la altura máxima en una lista de alturas.
// 38. Obtén los primeros 10 elementos de una lista de productos.
// 39. Salta los primeros 5 elementos de una lista de palabras y obtén los siguientes.
// 40. Elimina los elementos duplicados en una lista de nombres y ordénalos alfabéticamente.




