# Trabajo Práctico 2 Equipo 9C - Aplicación de Catálogo de Artículos (Winforms)

## Descripción
El siguiente trabajo práctico se trata de una aplicación de escritorio en WinForms para la gestión de artículos de un catálogo de comercio.

La aplicación permite:
* Listar artículos.
* Buscar artículos por distintos critertios.
* Agregar, modificar y eliminar artículos.
* Ver detalles de un artículo.
* Administrar Marcas y Categorías.
* Asociar una o varias imágenes a cada artículo.

El objetivo principal es aplicar buenas prácticas de separación de responsabilidades y trabajar con una arquitectura en capas, usando ADO.NET para el acceso a la base de datos.

---

## Arquitectura del proyecto
El proyecto está organizado en capas, cada una en un proyecto separado dentro de la solución:

| Proyecto | Contenido | Explicación |
|----------|-----------|------------|
| **CatalogoArticulos.UI** | Formularios de WinForms | Interfaz de usuario. Muestra datos y recibe entradas. Llama a las clases de la capa Negocio para realizar operaciones. |
| **CatalogoArticulos.Dominio** | Entidades (Articulo, Marca, Categoria, Imagen) | Define las entidades principales del sistema. No contiene lógica de negocio ni acceso a base de datos. |
| **CatalogoArticulos.Negocio** | Lógica de negocio + acceso a BD | Contiene métodos CRUD y reglas de negocio usando ADO.NET. La UI interactúa con esta capa para todas las operaciones. |
| **CatalogoArticulos.Comun** | Helpers, validadores, utilidades | Código reutilizable entre capas, como validaciones de datos, funciones auxiliares o constantes. |


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
* Las relaciones se representan en el modelo de dominio, no en la UI ni directamente en las clases de negocio.


---

## Tecnologías y herramientas
* Lenguaje: C#  
* Framework: .NET Framework 4.8  
* UI: Windows Forms  
* Acceso a datos: ADO.NET  
* Base de datos: SQL Server  
* Control de versiones: Git / GitHub

---

## Estructura de carpetas interna
```
CatalogoArticulos.UI/
├── Formularios/
│   ├── Articulos/
│   ├── Marcas/
│   └── Categorias/
├── Recursos/
└── Program.cs

CatalogoArticulos.Dominio/
└── Entidades/
├── Articulo.cs
├── Marca.cs
├── Categoria.cs
└── Imagen.cs

CatalogoArticulos.Negocio/
├── Articulos/
│   └── ArticuloNegocio.cs
├── Marcas/
│   └── MarcaNegocio.cs
└── Categorias/
└── CategoriaNegocio.cs

CatalogoArticulos.Comun/
└── Helpers/
├── ValidadorTexto.cs
├── ValidadorNumerico.cs
└── ValidadorImagen.cs
```

Hemos organizado cada carpeta con un propósito claro para cada una: UI solo para formularios, Dominio solo para entidades, Datos solo para acceso a base de datos, Servicios para lógica de aplicación, Comun para funciones compartidas.


---

## Integrantes
- Blandon, Kimberly
- Mondillo, Julián
