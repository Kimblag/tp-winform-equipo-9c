# TP2 - Aplicación de Catálogo de Artículos (Winforms)

## Descripción
El siguiente trabajo práctico se trata de una aplicación de escritorio en WinForms para la gestión de artículos de un catálogo de comercio.

La aplicación permite:
* Listar artículos.
* Buscar artículos por distintos critertios.
* Agregar, modificar y eliminar artículos.
* Ver detalles de un artículo.
* Administrar Marcas y Categorías.
* Asociar una o varias imágenes a cada artículo.

El objetivo principal es aplicar buenas prácticas de separación de esponsabilidades y trabajar con una arquitectura en capas, usando ADO.NET para el acceso a la base de datos.

---

## Arquitectura del proyecto
El proyecto está organizado en capas, cada una en un proyecto separado dentro de la solución:

| Proyecto | Contenido | Explicación |
|----------|-----------|------------|
| **CatalogoArticulos.UI** | Formularios de WinForms | Interfaz de usuario. Solo muestra datos y recibe entradas. Llama a los Servicios para realizar operaciones. |
| **CatalogoArticulos.Dominio** | Entidades (Articulo, Marca, Categoria, Imagen) | Modelo de negocio: clases que representan los datos y sus relaciones. |
| **CatalogoArticulos.Datos** | Repositorios e Interfaces | Acceso a la base de datos con ADO.NET. |
| **CatalogoArticulos.Servicios** | Servicios e Interfaces | Lógica de aplicación: validaciones simples y coordinación de llamadas a los repositorios. |
| **CatalogoArticulos.Comun** | Funciones compartidas, Helpers | Código reutilizable entre capas (validadores, constantes). |


Cada proyecto separado permite mantener el código organizado, controlar dependencias y facilita el antenimiento o cambios en el futuro.

---

## Base de datos
* Tablas principales: `ARTICULOS`, `MARCAS`, `CATEGORIAS`, `IMAGENES`.   
* Se usa **ADO.NET** para CRUD y consultas.

---

## Modelo de dominio
Se muestra el diagrama de clases que representa el modelo de dominio. ** Pendiente agregarlo aquí!!! 

**Resumen del modelo:**  
* Un Artículo pertenece a una Marca y a una Categoría.  
* Un Artículo puede tener una o varias Imágenes.  
* La relación entre entidades se refleja en el modelo de dominio, no en la UI ni en los repositorios.


---

## Tecnologías y herramientas
* .NET Framework 4.8
* WinForms
* ADO.NET
* SQL Server
* Git / GitHub para el control de versiones

---

## Estructura de carpetas interna
```
CatalogoArticulos.UI/
├── Formularios/
├── Recursos/
└── Program.cs

CatalogoArticulos.Dominio/
└── Entidades/

CatalogoArticulos.Datos/
├── Interfaces/
└── Repositorios/

CatalogoArticulos.Servicios/
├── Interfaces/
└── Implementaciones/

CatalogoArticulos.Comun/
└── Helpers/
```

Hemos organizado cada carpeta con un propósito claro para cada una: UI solo para formularios, Dominio solo para entidades, Datos solo para acceso a base de datos, Servicios para lógica de aplicación, Comun para funciones compartidas.


---

## Integrantes
- Blandon, Kimberly
- Mondillo, Julián