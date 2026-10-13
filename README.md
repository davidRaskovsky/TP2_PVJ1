# Metal Gear Solid: Ghost Infiltration - Prototipo Funcional
**Institución:** [Nombre de tu Instituto / Universidad]  
**Asignatura:** PROGRAMACIÓN DE VIDEOJUEGOS N°1  
**Trabajo Práctico:** N° 2  
**Modalidad:** Individual  
**Período de desarrollo:** 9 de octubre al 23 de octubre de 2026  

**Cuerpo Docente:**  
*   **Responsable de cátedra:** Mg. Ing. Ariel Alejandro Vega  
*   **JTP:** Tecn. Llampa Kevin Alexis Roman  

---

## 📝 Descripción del Proyecto
Este proyecto es un prototipo funcional de infiltración y acción sci-fi desarrollado bajo el encargo del equipo de producción de **CubeGame Studios**. El objetivo principal es validar la precisión de las interacciones por físicas, el comportamiento temporizado de los obstáculos del entorno, el transporte jerárquico de objetivos y la arquitectura de eventos para la condición de victoria dentro de un entorno tridimensional regulado.

### 🎮 Captura del Escenario
![Interfaz del Juego](Ruta_De_Tu_Imagen_Aqui.png)  
*(Nota: Reemplazá 'Ruta_De_Tu_Imagen_Aqui.png' por la ubicación de tu captura de pantalla dentro de la carpeta del proyecto, por ejemplo: Assets/Textures/screenshot.png)*

---

## 🛠️ Especificaciones Técnicas y Requisitos
*   **Motor de Desarrollo:** Unity [Colocá acá tu versión exacta, ej: 2022.3.Xf1] LTS.
*   **Lenguaje de Programación:** C# (.NET Standard 2.1).
*   **Configuración de Físicas:** Uso estricto de componentes `Rigidbody`, `MeshCollider` y `BoxCollider` con configuraciones dinámicas y estáticas diferenciadas.

---

## 🎮 Controles del Juego
El sistema de entrada está mapeado para teclado y mouse de la siguiente manera:

*   **Movimiento del Personaje:** Teclas `W`, `A`, `S`, `D` o Flechas de dirección.
*   **Interacción (Recoger / Soltar Objeto):** Tecla `E`.
*   **Cámara:** [Describí brevemente tu cámara, ej: Seguimiento automático en tercera persona / Movimiento libre con el Mouse].

---

## ⚙️ Mecánicas Implementadas

### 1. Escenario y Control de Personaje (Consigna 1)
*   **Estructura:** Escena 3D fluida que cuenta con un punto de inicio (Spawn), un circuito técnico de plataformas con obstáculos de salto, un ítem objetivo transportable y una zona de meta claramente delimitada por materiales contractivos.
*   **Jerarquía de Carpetas:** Estructura limpia y organizada según estándares de la industria:
    *   `Assets/Scenes`
    *   `Assets/Scripts`
    *   `Assets/Prefabs`
    *   `Assets/Materials`

### 2. Plataforma Móvil con Temporizador (Consigna 2)
*   **Comportamiento:** Una o más plataformas se desplazan continuamente entre dos coordenadas fijas del espacio utilizando cálculos vectoriales en `FixedUpdate()` para respetar las físicas del motor.
*   **Temporización:** Implementación de la función `Invoke()` para pausar, cambiar el estado o invertir la dirección de la plataforma de manera controlada por tiempo.

### 3. Generador de Obstáculos Dinámicos (Consigna 3)
*   **Spawner:** Un GameObject posicionado estratégicamente que utiliza `InvokeRepeating()` para instanciar proyectiles/obstáculos a intervalos de tiempo fijos y regulares.
*   **Optimización de Memoria:** Los proyectiles cuentan con un script de auto-destrucción basado en tiempo o límites físicos de salida para evitar la saturación de memoria del motor.

### 4. Recolección y Transporte Jerárquico (Consigna 4)
*   **Mecánica de Sujeción:** Al aproximarse al objeto y presionar la tecla `E`, el script ejecuta la función `SetParent()` asignando el objeto como hijo directo de un punto de anclaje (Socket) del personaje.
*   **Físicas en Transporte:** Al acoplarse se desactivan temporalmente las gravedades/físicas del objeto para evitar colisiones erráticas, restableciéndose al 100% con independencia jerárquica al pulsar nuevamente `E`.

### 5. Potenciador Temporal con Corrutina (Consigna 5)
*   **Capacidad Modificada:** [Escribí acá qué cambiaste, ej: Multiplicador de velocidad de movimiento (Speed Power-Up)].
*   **Asincronismo:** El temporizador del efecto y el tiempo de recarga global (*cooldown*) están gestionados de forma segura mediante una **corrutina de C#**, impidiendo la sobreescritura o reactivación del Power-Up mientras el ciclo no haya finalizado.

### 6. Zona de Entrega y Evento de Victoria (Consigna 6)
*   **Validación de Meta:** La zona de meta utiliza un Collider configurado en modo `Trigger`. El script de control valida estrictamente la identidad del objeto transportado y no la del jugador por separado.
*   **Feedback Visual:** La entrega exitosa del ítem correcto desencadena un evento que genera un cambio de estado visual y el despliegue del cartel de victoria.

---

## 🚀 Instrucciones para Abrir y Ejecutar el Proyecto
Para desplegar y probar este prototipo de manera local en tu entorno de desarrollo, ejecutá secuencialmente los siguientes pasos:

1.  **Clonar el repositorio:** Abrí tu terminal o Git Bash y ejecutá el comando:
    ```bash
    git clone https://github.com[Tu-Usuario-De-GitHub]/TP1_Prg1.git
    ```
2.  **Abrir Unity Hub:** Hacé clic en el botón **Add** (Añadir proyecto desde disco).
3.  **Seleccionar Carpeta:** Seleccioná la carpeta raíz llamada `TP1_Prg1` que acabás de clonar.
4.  **Iniciar el Motor:** Seleccioná la versión del editor correspondiente y esperá a que Unity inicialice las carpetas locales. El archivo `.gitignore` reconstruirá automáticamente la carpeta `Library/` local sin conflictos.
5.  **Cargar Escena:** En la ventana *Project*, navegá a `Assets/Scenes/` y abrí la escena principal para presionar el botón **Play**.
|