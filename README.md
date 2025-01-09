# Taller Formativo Mejores Prácticas

## Descripción
Este proyecto tiene como objetivo la implementación y demostración de patrones de diseño y buenas prácticas en el desarrollo de software. Se trabajó sobre una aplicación de automóviles que permite gestionar vehículos y simular funcionalidades sin necesidad de una base de datos lista. La solución implementada aplica principios **SOLID** y patrones de diseño como **Repository**, **Factory Method** y **Builder Pattern**, haciendo el sistema escalable, mantenible y fácil de probar.

---

## Tabla de Contenidos
1. [Descripción](#descripción)  
2. [Problemas Identificados](#problemas-identificados)  
3. [Cambios Implementados](#cambios-implementados)  
4. [Patrones de Diseño Aplicados](#patrones-de-diseño-aplicados)  
5. [Instalación](#instalación)  
6. [Ejecución del Proyecto](#ejecución-del-proyecto)  
7. [Autores](#autores)  
8. [Recursos Útiles](#recursos-útiles)  
9. [Licencia](#licencia)

---

## Problemas Identificados
1. **Repositorio defectuoso**: 
   - El patrón `Repository` estaba acoplado directamente a una base de datos no disponible.
2. **Base de datos no lista**:
   - Se necesitaba simular la funcionalidad sin persistir datos en una BD real.
3. **Nuevas propiedades**:
   - Se requerían propiedades adicionales que pudieran crecer sin romper la clase `Car`.
4. **Crecimiento futuro de modelos**:
   - La incorporación de nuevos modelos requería una arquitectura extensible.
5. **Falta de principios SOLID**:
   - El código existente no respetaba la separación de responsabilidades, causando acoplamiento.

---

## Cambios Implementados

1. **Migración a .NET 6**:
   - Actualización del proyecto para usar el framework .NET 6.

2. **Patrón Repository con Implementación en Memoria**:
   - Se creó `MyVehiclesRepository.cs`, que almacena datos en memoria para pruebas.
   - Se definió `IVehicleRepository` para desacoplar el repositorio de la lógica de negocio.

3. **Patrón Factory Method**:
   - Se implementaron fábricas específicas como `FordMustangCreator` y `FordExplorerCreator` para encapsular la creación de modelos.
   - Preparado para agregar nuevos modelos como `Escape` u otros futuros.

4. **Builder Pattern**:
   - Se creó `CarBuilder` para gestionar configuraciones de vehículos y facilitar la adición de propiedades futuras.

5. **Controlador Refactorizado**:
   - `HomeController.cs` ahora utiliza inyección de dependencias para trabajar con repositorios y fábricas.

6. **Inyección de Dependencias**:
   - Configurada en `ServicesConfiguration.cs` para utilizar implementaciones específicas.

7. **Vistas Simples**:
   - Se añadieron vistas (`Index.cshtml`, `ShowCars.cshtml`) para interactuar con el sistema y listar vehículos.

---

## Patrones de Diseño Aplicados

1. **Repository Pattern**:
   - Abstrae el acceso a datos con una implementación en memoria, preparada para migrar a una base de datos real en el futuro.

2. **Factory Method**:
   - Centraliza la creación de objetos específicos (`Mustang`, `Explorer`), facilitando la extensión.

3. **Builder Pattern**:
   - Simplifica la construcción de objetos `Car` con múltiples propiedades configurables.

4. **SOLID Principles**:
   - Aplicación de SRP (Single Responsibility), DIP (Dependency Inversion), y OCP (Open/Closed).

---

## Instalación

1. Clona el repositorio en tu máquina local:
   ```bash
   git clone https://github.com/MartinVargas07/TallerFormativo_MejoresPracticas.git
   cd TallerFormativo_MejoresPracticas
