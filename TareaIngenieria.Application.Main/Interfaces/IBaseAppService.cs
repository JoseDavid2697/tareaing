﻿using System.Collections.Generic;

namespace TareaIngenieria.Application.Main.Interfaces
{
    /**
     * <summary>Interfaz genérica que puede ser utilizado por cualquier entidad.</summary>
     */
    public interface IBaseAppService<TEntity> where TEntity : class
    {
        //Cualquier clase que implemente esta interfaz por debajo también implementa estos métodos
        /**
         * <summary>Método que permite ingresar una entidad</summary>
         * <param name="entity">Corresponde a la entidad que se desea agregar</param>
         */
        void add(TEntity entity);

        /**
         * <summary>Método que permite eliminar una entidad</summary>
         * <param name="id">Corresponde al identificador de la entidad que se desea eliminar</param>
         */
        void delete(int id);

        /**
         * <summary>Método que permite actualizar la información una entidad</summary>
         * <param name="entity">Corresponde a la entidad que se desea modificar</param>
         */
        void modify(TEntity entity);

        /**
         * <summary>Método que permite obtener todos los registros pertenecientes a esa entidad</summary>
         * <returns>Todos los objetos de ese tipo de entidad</returns>
         */
        IEnumerable<TEntity> getAll();

        /**
         * <summary>Método que permite obtener la información correspondiente a la entidad solicitada</summary>
         * <param name="id">Corresponde al identificador de la entidad que se desea obtener</param>
         * <returns>La información de la correspondiente entidad</returns>
         */
        TEntity getById(int id);

        void Dispose();
    }//Fin de la Interface IBaseAppService
}//Fin del namespace