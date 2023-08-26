using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using TestingASPNET.Datastructures;

namespace TestingASPNET.Controllers
{
    public class SortingController : Controller
    {
        [HttpPost]
        public IActionResult Sort([FromBody] int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return BadRequest("Array of numbers is required.");
            }

            SortingLinkedList<int> sortingLL = new SortingLinkedList<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                sortingLL.Append(numbers[i]);
            }

            QuickSort<int>.Sort(sortingLL);
            int[] sortedNumbers = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                sortedNumbers[i] = sortingLL.GetElementAt(i);
            }

            return Ok(new { sortedLL = sortedNumbers });
        }

        public IActionResult Index()
        {
            return View();
        }
    }
    class QuickSort<T> where T : IComparable<T>
    {
        public static void Sort(SortingLinkedList<T> list)
        {
            /*list.head = QuickSortMethod(list.head, null);*/
            list.BubbleSortMethod();
        }
    }
}
