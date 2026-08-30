# Mini-Proyecto Ágil: Calculadora

## Reflexión sobre Prácticas de Calidad Integradas

**1. ¿Qué práctica aplicaste?**
*   **Coding Standards:** Se implementó un archivo `.editorconfig` para estandarizar el formato del código y mantener reglas claras en Visual Studio.
*   **Pull Requests & Code Review:** Se trabajó el código en una rama aislada (`feature-calculadora`) y se realizó un Pull Request hacia la rama principal (`main`). Durante este proceso, se dejó un comentario de revisión de código proponiendo mejoras futuras antes de integrar los cambios.

**2. ¿Qué problema evita?**
*   El `.editorconfig` (Coding Standards) evita problemas de formato, código desordenado y conflictos de estilo cuando varios desarrolladores editan el mismo archivo.
*   El **Pull Request y el Code Review** evitan que código defectuoso, incompleto o con "bugs" llegue directamente a la versión final del producto, protegiendo la calidad del software.

**3. ¿Cómo se relaciona con lo discutido en clase?**
Estas prácticas previenen el temido efecto **"Big Bang"** (donde todos intentan integrar su código al final del proyecto, causando que el sistema colapse por conflictos incompatibles). Al integrar código en piezas pequeñas y revisadas continuamente, detectamos los errores temprano, lo cual **reduce drásticamente el retrabajo** y los costos en comparación a encontrar esos mismos errores en producción.
