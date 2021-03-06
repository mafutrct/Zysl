﻿using System;
using System.Collections.Generic;

namespace Zysl.KVS
{
	public interface IKVStore<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>
	{
		bool ContainsKey (TKey key);

		long Count { get; }

		void Dispose ();

		void Flush ();

		bool Remove (TKey key);

		TValue this[TKey key] { get; set; }

		bool TryGetValue (TKey key, out TValue value);

		IEnumerable<TKey> Keys { get; }

		IEnumerable<TValue> Values { get; }
	}
}
