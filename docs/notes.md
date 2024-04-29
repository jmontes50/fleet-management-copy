**.NET**

En el mundo de C# (csharp) y .NET, es importante entender que C# es el lenguaje de programación, orientado al paradigma de Programación Orientada a Objetos (POO), mientras que .NET es el framework o marco de trabajo. Para hacer una comparación simple, podríamos decir que Javascript se relaciona con el framework Express de manera similar a cómo C# se relaciona con el framework .NET.

.NET cuenta con varias versiones, y al igual que otras tecnologías como Node, ofrece ediciones de Soporte a Largo Plazo (LTS) que reciben respaldo durante tres años. Actualmente, las versiones 6 y 8 de .NET están bajo este modelo de soporte LTS.

La versión 6 de .NET recibirá soporte hasta noviembre de 2024, mientras que la versión 8 lo tendrá hasta noviembre de 2026. Aunque la versión 8 introduce nuevas características, muchas de ellas son utilizables incluso en versiones anteriores, como la 6 o la 5 de .NET.

En el paradigma de POO en C#, se trabajará con clases, que actúan como moldes para la creación de objetos. Estos objetos comparten las mismas propiedades, aunque con valores diferentes. Cada propiedad en una clase tiene dos métodos: get para obtener el valor y set, opcional, para cambiar o asignar un valor a esa propiedad.

```csharp
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }
    }
```

Otras diferencias notables incluyen que el constructor de una clase en C# tiene el mismo nombre que la clase. Además, al ser un lenguaje tipado, se especifica el tipo de dato al definir propiedades y métodos, indicando si son públicos, protegidos o privados.

```csharp
public class EjemploClase
{
    private int numeroPrivado;

    public int ObtenerNumero()
    {
        return numeroPrivado;
    }

    public void AsignarNumero(int nuevoNumero)
    {
        numeroPrivado = nuevoNumero;
    }
}
```

En cuanto a la herencia, se pueden crear subclases para heredar propiedades y métodos de las clases principales. Esto incluye la posibilidad de sobrescribir un método con las palabras clave "virtual" en la clase principal y "override" en la subclase. También se destaca la sobrecarga de métodos, permitiendo tener funciones con el mismo nombre pero diferentes tipos de argumentos.

Interfaces actúan como contratos, indicando que una clase o función debe cumplir con ciertos requisitos. Una clase puede implementar varias interfaces, lo que contribuye a una arquitectura más limpia y clara.

Los "generics" permiten indicar el tipo de dato al instanciar una clase.

```csharp
public class Contenedor<T>
{
    private T contenido;

    public Contenedor(T item)
    {
        contenido = item;
    }

    public T ObtenerContenido()
    {
        return contenido;
    }
}
```

Para definir JSON, se usa el símbolo "@" antes de las comillas y se utilizan comillas dobles para propiedades y strings dentro del JSON. Para serializar o deserializar, se emplean los métodos `JsonSerializer.Serialize(obj)` y `JsonSerializer.Deserialize<ClassName>(json)`.

Aunque C# sigue un paradigma orientado a objetos, también es posible definir funciones con una sintaxis similar a JavaScript. Además, se pueden pasar funciones como parámetros, indicando el tipo de dato con `Action<ParamsTypes>` o `Func<paramsTypes, returnType>`.

Las "Lambda Expressions" son equivalentes a las funciones flecha en JS, permitiendo escribir funciones anónimas sin necesidad de darles un nombre.

LINQ facilita las consultas a fuentes de datos, como listas o bases de datos, con una sintaxis que recuerda a consultas SQL.

La estructura de archivos en un proyecto .NET incluye:

- **Program.cs:** Contiene la clase principal del programa, actuando como el punto de entrada para la aplicación.
- **Controllers:** Directorio con controladores de la API que manejan solicitudes HTTP y devuelven respuestas.
- **<nameProject>.csproj:** Archivo de configuración del proyecto, similar a un package.json.
- **appsettings.json:** Archivo con la configuración de la aplicación, como opciones de conexión a la base de datos.
- **Properties:** Directorio con información sobre el proyecto, como versión e información de compilación.
- **Models:** Directorio con modelos de datos utilizados por la API, representando los recursos expuestos.
