# 🎮 Clase 1 — Consola, Git y Lógica C# en Unity

> Proyecto de práctica: vas a usar la consola de Unity, versionar tu código con Git y escribir tu primera lógica en C#.

---

## ⚙️ Setup Inicial

### 1. Requisitos
- [Unity Hub](https://unity.com/download) con **Unity 6** instalado
- [Git](https://git-scm.com/) + cuenta en [GitHub](https://github.com)

### 2. Clonar el repositorio
```bash
git clone https://github.com/KinnaGt/Pira-Introduccion-Unity.git
```

### 3. Abrir en Unity
Unity Hub → **Open** → seleccionar la carpeta del proyecto.  
Cargar la escena: `Assets/Clase1/Scenes/Class_1_Task.unity`

---

## 🔁 Control de versiones — Git

Antes de empezar a codear, creá tu propio repositorio en GitHub y vinculalo al proyecto. A medida que avancés, guardá tu progreso con commits.

```bash
git add .
git commit -m "descripción de lo que hiciste"
git push origin main
```

> **Analogía:** `commit` es sacar una foto del proyecto en un momento dado. `push` es subirla a la nube. Si algo se rompe, podés volver a cualquier foto anterior — es tu botón de deshacer global.

**Entregable mínimo: al menos 2 commits con mensajes descriptivos.**

---

## 📝 Tareas

### Script 1 — `JuanSalvo.cs`

Abrí el archivo en `Assets/Clase1/Scripts/JuanSalvo.cs`.

**TAREA 1:** Declará tres variables al comienzo de la clase:
- Una de tipo `string` para el nombre
- Una de tipo `int` para la edad  
- Una de tipo `float` para la altura

> Las variables son cajitas con nombre donde guardás un valor. Cada tipo de cajita tiene un tamaño diferente en memoria: `int` guarda enteros, `float` guarda decimales (siempre terminan en `f`, ej: `1.80f`), `string` guarda texto.

**TAREA 2:** Dentro del método `MostrarDatos()`, construí una frase con tus variables y asignala a `_finalMessage` usando concatenación de strings con el operador `+`.

> Cuando el script inicia, Unity llama automáticamente a `Start()`. Ese método llama a `MostrarDatos()`, que imprimirá tu mensaje en la consola y lo mostrará en pantalla.

**Tip:** Fijate que `_uiText` tiene el atributo `[SerializeField]`. Eso hace que una variable `private` aparezca en el Inspector de Unity para poder asignarla desde el editor, sin exponer la variable al resto del código.

---

### Script 2 — `LogButtons.cs`

Abrí el archivo en `Assets/Clase1/Scripts/LogButtons.cs`.

Hay tres botones en la escena, cada uno conectado a un método. Tu tarea es completar cada método usando la clase `Debug` de Unity:

| Método | Consigna | Ícono en consola |
|--------|----------|-----------------|
| `LogInfoMessage()` | Imprimí un mensaje normal | ⬜ blanco |
| `LogWarningMessage()` | Imprimí una advertencia | 🔶 amarillo |
| `LogErrorMessage()` | Imprimí un error | 🔴 rojo |

Investigá en la [documentación de Unity](https://docs.unity3d.com/ScriptReference/Debug.html) los tres métodos de `Debug` que corresponden a cada tipo.

**PLUS — `LogErrorMessage()`:** Investigá cómo hacer que Unity se **pause automáticamente** al ejecutar ese método. La respuesta también está en la documentación de `Debug`.

---

## 🧠 Conceptos de C# que necesitás

### Variables y tipos
```csharp
int    numero = 10;      // Entero
float  decimal = 3.14f;  // Decimal (requiere la f al final)
bool   condicion = true; // Solo true o false
string texto = "Hola";   // Cadena de caracteres
```

### void vs return
- Un método `void` **hace algo** pero no te devuelve ningún valor.
- Un método con tipo de retorno (`int`, `string`, etc.) **te responde algo** con `return`.

```csharp
void Saludar()           // No devuelve nada
{
    Debug.Log("Hola");
}

int Sumar(int a, int b)  // Devuelve un int
{
    return a + b;
}
```

### if / else
```csharp
if (condicion)
{
    // Se ejecuta si condicion es true
}
else
{
    // Se ejecuta si condicion es false
}
```

---

## ✅ Checklist de entrega

- [ ] Repositorio en GitHub con la tarea.
- [ ] `JuanSalvo.cs`: variables declaradas y `_finalMessage` construido
- [ ] `LogButtons.cs`: los 3 métodos de log implementados
- [ ] **PLUS:** Unity se pausa al presionar el botón de error
- [ ] **PLUS:** Se cambiaron los sprites de los botones por los que estan en la carpeta Assets/Clase1/Art/Buttons
- [ ] La escena corre **sin errores** en la consola de Unity

---

## 📚 Recursos

- [Debug — Unity Scripting API](https://docs.unity3d.com/ScriptReference/Debug.html)
- [Ciclo de vida de MonoBehaviour](https://docs.unity3d.com/Manual/ExecutionOrder.html)
- [Git — Guía de inicio rápido](https://docs.github.com/es/get-started/quickstart)