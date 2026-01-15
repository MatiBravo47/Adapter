# Adapter Pattern – Ejemplo de Conversión de Temperatura 🌡️

Este repositorio contiene un ejemplo simple y didáctico del **patrón de diseño Adapter**, implementado en **C#**.

El objetivo es mostrar cómo adaptar una clase existente con una interfaz incompatible, sin modificar su código original.

---

## 🧠 ¿Qué problema resuelve el patrón Adapter?

El patrón Adapter se utiliza cuando:

- Existe una clase que **ya funciona correctamente** (Adaptee)
- Pero su **interfaz no es compatible** con lo que el cliente necesita
- No podemos o no queremos modificar esa clase

👉 El Adapter actúa como un **traductor** entre ambas partes.

---

## 🧩 Ejemplo del repositorio

### 📌 Escenario
- El **cliente** trabaja con temperaturas en **grados Celsius**
- Una clase existente devuelve la temperatura en **grados Fahrenheit**
- Se crea un **Adapter** para convertir Fahrenheit a Celsius

---

## 🧱 Estructura del patrón en el código

| Rol del patrón | Clase |
|---------------|------|
| Target | `ITemperatureCelsius` |
| Adaptee | `FahrenheitSensor` |
| Adapter | `TemperatureAdapter` |
| Client | `Program` |

---

## 🔁 Conversión utilizada

```text
Celsius = (Fahrenheit - 32) × 5 / 9

