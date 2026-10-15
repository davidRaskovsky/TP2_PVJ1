# Metal Gear Solid: Ghost Infiltration - Prototipo Funcional (TP2)
**Institución: Facultad de Ingeniria de Jujuy / UnJu**  
**Asignatura:** PROGRAMACIÓN DE VIDEOJUEGOS N°1  
**Trabajo Práctico:** N° 2  
**Nombre del Repositorio:** TP2_PVJ1  
**Modalidad:** Individual  
**Período de desarrollo:** 9 de octubre al 23 de octubre de 2026, 23:59 hs  

**Cuerpo Docente:**  
*   **Responsable de Cátedra:** Mg. Ing. Ariel Alejandro Vega  
*   **JTP:** Tecn. Llampa Kevin Alexis Roman  

**Estudiante:**  
*   ** David Adrián Raskovsky **  
*   ** LU TUV000629 **

---

## 📝 Presentación del Proyecto
Prototipo funcional de infiltración y acción sci-fi desarrollado en respuesta a la *Carta de Encargo de CubeGame Studios*. El proyecto valida la viabilidad técnica de interacciones basadas en física de rayos, navegación autónoma de agentes de Inteligencia Artificial en entornos tridimensionales orgánicos y una arquitectura centralizada para la gestión de estados de juego.

---

## 🖥️ Versión del Motor
*   **Unity Editor: 6000.5.8f1_5cb7df797b7d (Unity 6.5) Revision 6000.5/staging 5cb7df797b7d** 
*   **Librerías Clave:** 

---

## 🎮 Guía de Controles
*   **Movimiento del Jugador:** Teclas `W`, `A`, `S`, `D` / Flechas direccionales.
*   **Salto (Validado por Raycast):** Barra Espaciadora (`Space`).
*   **Interacción (Raycast Frontal):** Tecla `E` (Para activar consolas, terminales de datos o puertas).
*   **Pausa del Sistema:** Tecla `P` o `Esc` (Congela el tiempo de juego).

---

## ⚙️ Detalle de Mecánicas Obligatorias Implementadas

### 1. Detección e Interacción por Raycast y LayerMask
*   **Chequeo de Suelo:** Se proyecta un rayo descendente desde la base del jugador. El script de salto valida la distancia con el suelo filtrando por físicas, garantizando que el personaje no pueda realizar saltos infinitos en el aire.
*   **Interacción a Distancia:** Al presionar la tecla de interacción apuntando a un elemento del entorno, se genera un Raycast frontal. Utiliza una máscara de capa (`LayerMask`) para ignorar colisionadores decorativos e interactuar únicamente con objetos de la capa `Interactable`.

### 2. Navegación e Inteligencia Artificial (NavMesh)
*   **Malla de Navegación:** Escenario completamente horneado mapeando las zonas transitables, rampas y obstáculos físicos permanentes.
*   **Centinela / Dron Enemigo:** Agente configurado con el componente `NavMeshAgent`. Cuenta con una máquina de estados simple programada para patrullar puntos específicos y cambiar automáticamente a persecución agresiva al calcular que el jugador entró en su rango de visión.

### 3. Gestión de Salud, Puntuación y Terreno
*   **Salud y Daño:** El jugador posee una barra/contador de vida. El daño se aplica por contacto directo con los enemigos o trampas activas.
*   **Puntuación:** Distribución de contenedores de datos recolectables por el mapa que incrementan el puntaje central al ser validados por triggers.
*   **Modelado del Entorno:** Escenario modelado con la herramienta *Terrain Tool* de Unity, aplicando texturas de superficies mixtas, desniveles orgánicos y rampas funcionales para el agente de IA.

### 4. GameManager y Control de Estados
*   **Arquitectura Centralizada:** Script `GameManager.cs` estructurado de forma independiente para administrar el bucle general de juego mediante una máquina de estados: `Start`, `Playing`, `Paused`, `Victory` y `GameOver`.
*   **Pausa:** El estado de pausa detiene el reloj del motor mediante `Time.timeScale = 0`.
*   **Logs de Consola:** El sistema notifica en tiempo real por la consola de Unity cada cambio de estado, variaciones en la salud y la recolección de puntos.

---

## 🚀 Requisitos Opcionales Elegidos (Mínimo 3)
*Acá debés elegir 3 opciones de las que te dio el profesor (A, B, C, D, E o F), borrar las que no uses y explicar brevemente qué script las controla:*

*   **[Opción Elegida 1 (Ej: Opción A - Arma por Raycast)]:** [Explicación técnica breve: Se implementó un Raycast ofensivo que al impactar al enemigo accede a su NavMeshAgent y lo congela seteando su velocidad a 0 durante 3 segundos. Programado en `WeaponController.cs`].
*   **[Opción Elegida 2 (Ej: Opción D - Zona de Barro)]:** [Explicación técnica breve: Trigger que modifica el atributo speed del Player al entrar y lo restablece al salir. Programado en `MudZone.cs`].
*   **[Opción Elegida 3 (Ej: Opción F - Zona de Gas Tóxico)]:** [Explicación técnica breve: Área de peligro que ejecuta un daño por segundo continuo mediante un contador temporizado mientras el jugador permanezca dentro. Programado en `ToxicGas.cs`].

---

## 📸 Capturas del Proyecto en Ejecución
A continuación se anexan las capturas obligatorias que demuestran el correcto funcionamiento del terreno, el NavMesh de los enemigos y el flujo del juego en Unity:

1. **Vista General del Terreno e Infiltración:**
   ![Captura 1](Ruta_De_Tu_Imagen_1.png)
   
2. **Sistema de IA y Detección de Enemigos:**
   ![Captura 2](Ruta_De_Tu_Imagen_2.png)
---

## 📊 6. Rúbrica de Evaluación y Matriz de Desempeño
El proyecto ha sido desarrollado bajo los estándares de la siguiente matriz analítica de desempeño para asegurar la máxima calificación:

| Dimensión | Logro Inicial (1 - 3) | Logro en Proceso (4 - 6) | Logro Esperado (7 - 8) | Logro Destacado (9 - 10) |
| :--- | :--- | :--- | :--- | :--- |
| **1. Raycast y LayerMask** | No implementa Raycast o presenta errores graves en la consola que impiden detectar el suelo o interactuar. | Implementa Raycast de forma parcial, sin aplicar LayerMask para filtrar objetos o con problemas en la distancia. | Programa correctamente el chequeo de suelo y la interacción a distancia con Raycast y LayerMask. | Programa correctamente el chequeo de suelo y la interacción a distancia con Raycast y LayerMask con precisión absoluta. |
| **2. NavMesh e IA** | El enemigo no se desplaza, genera errores de compilación o no se horneó la malla de navegación. | Configura NavMesh pero el enemigo pierde el objetivo, se traba con obstáculos o no reacciona al rango de visión. | Configura el enemigo de forma funcional, logrando patrulla y persecución efectiva del jugador. | Diseña una IA enemiga fluida con NavMesh, con radios de detección bien calibrados y comportamientos de persecución limpios. |
| **3. Gestión de Salud, Puntuación y Terreno** | No registra el daño/salud, no hay recolección de puntos y se omite el uso de la herramienta de terrenos. | El sistema de daño o puntos falla en la acumulación, o el terreno carece de desniveles y texturas aplicadas. | Integra correctamente el sistema de salud, el sistema de puntos y un terreno creado con Terrain Tool. | Presenta un mapa estético y desafiante en el terreno, con una gestión limpia de puntos e impacto de daño al jugador. |
| **4. GameManager y Estados** | La lógica de estado está sobrecargada en el Player, no hay GameManager o el flujo de juego no responde. | Crea el GameManager pero presenta fallos al cambiar de estado, la pausa no detiene el juego o faltan avisos en consola. | Implementa un GameManager que administra los estados de juego y la pausa, informando por consola. | Diseña un GameManager ejemplar, con manejo de eventos claros y control total del bucle de juego. |
| **5. Versionamiento (Git/GitHub)** | No incluye .gitignore, carece de historial de commits o la entrega no es un enlace válido. | Historial de commits escaso, .gitignore incompleto o el archivo README.md no contiene la información solicitada. | Repositorio con .gitignore correcto, commits progresivos claros y un README.md estructurado en Markdown. | Repositorio impecable, excelente gestión de commits y un README.md detallado con capturas. |
| **6. Requisitos Opcionales** | No implementa requisitos opcionales o los presentados contienen errores que rompen la ejecución del proyecto. | Implementa solo 1 opcional o presenta 2 con fallos de integración mecánicos. | Implementa correctamente 1 o 2 requisitos opcionales, aportando valor pero sin completar el cupo de 3. | Implementa correctamente al menos 3 requisitos opcionales a elección, demostrando un valor agregado notable permitiendo alcanzar la calificación máxima. |




