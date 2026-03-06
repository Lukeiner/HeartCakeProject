# Heart Cake Interactive Experience - Unity 3D

Este proyecto es una experiencia interactiva publicitaria desarrollada en Unity para tótems touchscreen Windows. El objetivo es permitir al usuario personalizar un producto alimenticio ("Heart Cake") de forma intuitiva y visualmente atractiva.

## 🚀 Características Principales

- **Personalización en Tiempo Real:** Cambio dinámico de sabores (materiales) para el bizcochuelo[cite: 13, 15].
- **Sistema de Rotación:** Control suave del producto para visualización 360° mediante un `RotationHandler` dedicado[cite: 16, 21].
- **Feedback Sensorial:** Sistema de partículas de confeti y efectos de sonido al finalizar la decoración para mejorar la experiencia del usuario (UX)[cite: 17].
- **Diseño Publicitario:** Interfaz diseñada con una alineación en "Z" para seguir el recorrido natural del ojo humano[cite: 8].

## 🛠️ Detalles Técnicos

- **Motor:** Unity 2022.3+ (o la versión que usaste).
- **Render Pipeline:** Universal Render Pipeline (URP) para optimizar el rendimiento visual.
- **Arquitectura de Scripts:** - `CakeController`: Gestiona la lógica de materiales y elementos decorativos[cite: 13, 15].
- `RotationHandler`: Controla el movimiento rotatorio independiente del modelo[cite: 16].
- `CelebrationHandler`: Administra el sistema de partículas y audio de recompensa[cite: 17].

## 📐 Decisiones de Diseño

- **Estética:** Se optó por tonos rosas y pasteles para generar una sensación amigable y simpática, alineada con las tendencias actuales de redes sociales[cite: 7, 9].
- **Resolución:** Optimizado para tótems verticales (Portrait) en 1080x1920[cite: 5].
- **UI/UX:** Uso de elementos visuales claros para guiar al usuario a través del proceso de decoración[cite: 12].

## 📌 Próximas Mejoras (Roadmap)

Según el análisis de post-desarrollo, se han identificado las siguientes áreas de mejora para futuras versiones[cite: 26, 27]:
1. Implementación de toppings 3D (frutillas, cerezas) mediante prefabs dinámicos[cite: 31, 32].
2. Inclusión de fuentes tipográficas personalizadas con temática de pastelería[cite: 28].
3. Efecto de *Outline* (contorno) para resaltar el estilo "caricatura" del modelo 3D[cite: 34].

## 📦 Instalación y Uso

1. Clonar el repositorio.
2. Abrir el proyecto en Unity Hub (asegurarse de que la carpeta `Library` se genere automáticamente).
3. La escena principal se encuentra en `Assets/Scenes/CakeProject`.
