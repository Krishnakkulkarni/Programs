//-----------------------------------------------------------------------
// <copyright file="ILinkedList.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace ObjectOrientedPrograms.CommercialDataProcessing
{
    /// <summary>
    /// Interface of Linked List
    /// </summary>
    /// <typeparam name="T">Generic type T</typeparam>
    public interface ILinkedList<T>
    {
        /// <summary>
        /// Instance of Add
        /// </summary>
        /// <param name="word">Generic type Word as a parameter</param>
        /// <returns>returns Generic type Word</returns>
        bool Add(T word);

        /// <summary>
        /// Instance of Is Empty
        /// </summary>
        /// <returns>returns empty</returns>
        bool IsEmpty();

        /// <summary>
        /// Instance of Size
        /// </summary>
        /// <returns>returns size</returns>
        long Size();

        /// <summary>
        /// Instance of Delete 
        /// </summary>
        /// <param name="wordToSearch">word To Search</param>
        /// <returns>returns delete</returns>
        bool Delete(string wordToSearch);

        /// <summary>
        /// Instance of Insert
        /// </summary>
        /// <param name="data">data as a parameter</param>
        /// <param name="position">position is a parameter</param>
        /// <returns>returns Generic type data and long type position</returns>
        bool Insert(T data, long position);

        /// <summary>
        /// Instance of Print
        /// </summary>
        void Print();

        /// <summary>
        ///  Instance of Contains
        /// </summary>
        /// <param name="word">word as a parameter</param>
        /// <returns>returns word</returns>
        bool Contains(T word);
    }
}