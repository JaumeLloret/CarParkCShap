
# CarParkCShap
Esta práctica tiene como objetivo afianzar los conceptos de herencia, polimorfismo e interfaces, además de practicar la clase ArrayList (listas genéricas de objetos).

Vamos parque de vehículos no sólo a Coches, si no a Vehículos en general, utilizando la herencia, el polimorfismo y las interfaces. En nuestro parque de vehículos podrán aparcarse diferentes tipos de vehículos:
- Car
- Bus
- Motorcycle
- Plane
- Yacht

Todos ellos heredarán de la clase Vehiculo, que será abstracta, y tendrán los siguientes atributos en común:
- **registration**: *string*. Con un valor aleatorio por defecto, al crearse el objeto. Ésta no se pasará por parámetro, se asignará un valor aleatorio al crear el vehículo.
- **brand**: *string*.
- **model**: *string*.
- **color**: *string*. Por defecto, el color será blanco
- **kilometres**: *uint*. Inicialmente será 0.
- **numberOfDoors**: *byte*.
- **numberOfPlaces**: *byte*.

Se definirá una variable estática para el número de vehículos y una constante estática para el máximo de vehículos (por defecto, 5).

La clase **Vehicle** dispondrá como mínimo de dos constructores, uno sin parámetros, inicializando con valores por defecto y otro con parámetros, para pasarle valores. También dispondrá de los métodos:

- *start()*, *accelerate()* y *brake()*: todos ellos, métodos abstractos que se implementarán en cada clase concreta. Mostrarán por pantalla la acción realizada por cada vehículo.
- *toString()*: método sobreescrito que en la implementación en cada clase concreta devolverá una cadena (String) con una explicación de las características de cada objeto. Podrá definirse parte del método en la clase abstracta **Vehicle** y después, sobreescribiendo el método en las clases concretas.

Además, para cada clase concreta, se crearán los siguientes atributos:

> ## Car
>**numberOfAirbags** : *byte*
>**solarRoof** : *bool*
>**hasRadio** : *bool*

> ## Bus
>**typeRoute** : *string*
>**isScholar** : *bool*
  
> ## Motorcycle
>**powerEngine** : *uint*
>**hasTrunk** : *bool*

> ## Plane
>**airport** : *string*
>**maximumWeightSupported** : *byte*

> ## Yacht
>**hasKitchen** : *bool*
>**numberOfEngines** : *byte*
>**metersOfLength** : *byte*

Algunos de los vehículos podrán circular (caminar), otros podrán volar, otros podrán navegar. Para ello, utilizaremos las interfaces: (que definen comportamientos)
- ***CanCirculate***: por tierra
- ***CanNavigate***: por agua
- ***CanFly***: por aire

Cada interfaz contendrá un método abstracto llamada *circle()*, *navigate()* o *fly()*, que en las clases concretas mostrará por pantalla un mensaje indicando en qué lugares puede realizar dichas acciones o comportamientos.

> *circle()* para un **Car**: “Esto es un coche y los coches puede circular por carreteras, autovías y autopistas”.

> *circle()* para una Plane: “Esto es una avioneta y las avionetas sólo pueden circular dentro de los aeropuertos.”

Como mínimo, para cada clase concreta, definiremos el constructor sin parámetros y otro constructor al que le pasemos los parámetros importantes.

Con dos constructores por clase será suficiente. Dichos constructores harán una llamada a los constructores de la superclase para inicializar variables comunes a todas las clases concretas.

Aparte de los propios *setters* y *getters* de cada clase, y de los constructores ya explicados, cada clase concreta dispone de los siguientes métodos:

> ## Car
>**Tuning(color)**:*string*. Este método deja el cuentakilómetros a cero y le instala un techo solar, en el caso de que no lo tuviera ya instalado. Y pinta el coche de un color. Devuelve un mensaje indicando la operación.
>**Park()**:*string*. Este método devolverá un mensaje que el coche está aparcando.

> ## Bus
>**OpenDoors** : *string*. Devuelve un mensaje indicando la operación.
>**Park()**:*string*. Este método devolverá un mensaje que el autobús está aparcando.
  
> ## Motorcycle
>**Jump** : *string*. Devuelve un mensaje indicando la operación.
>**Park()**:*string*. Este método devolverá un mensaje que la moto está aparcando.

> ## Plane
>**TakeOff()** : *string*. Este método devolverá un mensaje que el avión está despegando.
>**Landing()** : *string*. Este método devolverá un mensaje que el avión está aterrizando.

> ## Yacht
>**Sail()** : *string*. Este método devolverá un mensaje que el yate está partiendo.
>**Dock()** : *string*. Este método devolverá un mensaje que el yate está amarando.

Se creará una clase llamada **Store**, en la que implementaremos el programa principal, que realizará las siguientes acciones:
 - Mostrará un menú para crear los 5 tipos de vehículos pidiendo los datos necesarios en cada caso.
- Los vehículos creados se irán almacenando en un objeto de tipo lista.
- El menú permitirá mostrar los datos de cada vehículo del parque.

Las opciones del menú serán: (a modo de ejemplo, pero podrá variarse)

 1. Crear un coche (con o sin datos)
 2. Crear un autobús (con o sin datos)
 3. Crear una motocicleta (con o sin datos)
 4. Crear una avioneta (con o sin datos)
 5. Crear un yate (con o sin datos)
 6. Mostrar características de todos los vehículos del parque
 7. Salir del programa

Tened en cuenta que los objetos en la lista serán de tipo más genérico. Por tanto, el programa deberá comprobar el tipo de cada objeto para ir mostrando sus capacidades e ir realizando las operaciones con cada vehículo. Para ello, se definirán dos métodos en la clase Parque:
- *GetVehicleType()*: se le pasará por parámetro un vehículo de tipo **Vehicle**, obtenido de la lista, y el método devolverá un entero indicando el tipo de vehículo.
- ShowListOfVehicles(): se le pasará por parámetro una lista y lo recorrerá para ir mostrando los datos (*stats*()) y las capacidades (interfaces: qué es capaz de hacer) de cada vehículo. Este método llamará a *GetVehicleType()* para saber el tipo de cada objeto obtenido de la lista, y realizará un casting del objeto, para actuar con él como un objeto de su tipo concreto correspondiente.
