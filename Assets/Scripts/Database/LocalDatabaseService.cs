using SQLite4Unity3d;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace EnglishWordReminder
{
	public class LocalDatabaseService
	{
		private SQLiteConnection _connection;

		private LocalDatabaseService()
		{
			CreateDatabaseConnection();
		}

		#region Singleton

		private static readonly object _lock = new object();
		private static LocalDatabaseService instance = null;
		public static LocalDatabaseService Instance
		{
			get
			{
				if (instance == null)
				{
					lock (_lock)
					{
						if (instance == null)
						{
							instance = new LocalDatabaseService();
						}
					}
				}
				return instance;
			}
		}

		#endregion

		private void CreateDatabaseConnection()
		{
			var dbPath = $"{Application.persistentDataPath}/EnglishWordReminderDB";
			_connection = new SQLiteConnection(dbPath, SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create);

			_connection.CreateTable<DBWord>();
		}

		public Queue<DBWord> GetWordsForBox(WordBoxType wordBox)
		{
			Queue<DBWord> words = new Queue<DBWord>();
			try
			{
				var wordsList = _connection.Table<DBWord>().Where(w => w.WordBox == (int)wordBox).ToList();

				Utility.LinqHelper.ListModifier.Shuffle(wordsList);

				foreach (var word in wordsList)
				{
					words.Enqueue(word);
				}
			}
			catch (Exception e)
			{
				Debug.LogError($"Error on getting random word from box in database error is: {e.Message}");
				throw;
			}

			return words;
		}


	}
}
