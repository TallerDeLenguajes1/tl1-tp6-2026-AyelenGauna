# String en C#

## ¿String es un tipo por valor o un tipo por referencia?

`string` es un **tipo por referencia** en C#. Internamente, es una instancia de la clase `String`, que pertenece al espacio de nombres `System`. Sin embargo, tiene un comportamiento especial: es **inmutable**, lo que significa que una vez creada una cadena de texto, su contenido no puede modificarse. Cuando parece que se modifica un string, en realidad se crea una nueva instancia.

## ¿Qué secuencias de escape tiene el tipo string?

Las secuencias de escape más utilizadas en cadenas de texto son:

| Secuencia | Descripción                 |
| --------- | --------------------------- |
| `\n`      | Salto de línea              |
| `\r`      | Retorno de carro            |
| `\t`      | Tabulación horizontal       |
| `\\`      | Barra invertida (`\`)       |
| `\"`      | Comilla doble (`"`)         |
| `\'`      | Comilla simple (`'`)        |
| `\0`      | Carácter nulo               |
| `\a`      | Alerta o sonido del sistema |
| `\b`      | Retroceso (backspace)       |
| `\f`      | Salto de página             |
| `\v`      | Tabulación vertical         |

Ejemplo:

```csharp
string mensaje = "Hola\nMundo";
```

## ¿Qué sucede cuando se utiliza el carácter @ y $ antes de una cadena de texto?

### Carácter `@`

Convierte la cadena en una **cadena literal textual** (verbatim string). En este tipo de cadenas no es necesario escapar las barras invertidas (`\`) ni los saltos de línea.

Ejemplo:

```csharp
string ruta = @"C:\Users\Ayelen\Documents";
```

### Carácter `$`

Permite realizar **interpolación de cadenas**, es decir, insertar valores de variables o expresiones directamente dentro del texto utilizando llaves `{}`.

Ejemplo:

```csharp
string nombre = "Ayelen";
string mensaje = $"Hola, {nombre}";
```

Resultado:

```text
Hola, Ayelen
```

### Uso combinado de `$@` o `@$`

Es posible combinar ambos caracteres para utilizar una cadena literal textual e interpolada al mismo tiempo.

Ejemplo:

```csharp
string carpeta = "Documentos";
string ruta = $@"C:\Users\Ayelen\{carpeta}";
```

Resultado:

```text
C:\Users\Ayelen\Documentos
```
