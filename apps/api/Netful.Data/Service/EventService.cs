using System;
using System.Collections.Generic;
using _Net.Data.Context.*;

namespace _Net.Data.Service
{
	public User SaveUser (User user) {
		if (user == null) {
			throw new ArgumentNullException("User is Null");
		}

		using (var context = new EventContext(options))
		{
			context.users.Add(user);
			context.SaveChanges();
		}

		return user;
	}

	public
}