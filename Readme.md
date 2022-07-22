# InteropServices in Windows Forms with C#

[![Captura-de-pantalla-2022-07-21-215250.png](https://i.postimg.cc/nhtFc1yS/Captura-de-pantalla-2022-07-21-215250.png)](https://postimg.cc/1fJhvD5D)

Uso de eventos de comandos para controlar elementos multimedia en Windows Forms con C#.

Uso de ```System.Runtime.InteropServices``` para enviar eventos de comandos:

```cs
public static extern IntPtr SendMessageW(Puntero Handle, Mensaje en Hexaderimal, Puntero en Hexadecimal);
```
