﻿namespace Keyboard_Cats.Models
{
    public class AuthResponse
    {
      public string token_type { get; set; }
      public int expires_in { get; set; }
      public string access_token { get; set; }

    }
}
