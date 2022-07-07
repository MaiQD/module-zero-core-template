﻿using Dat.Quiz.Debugging;

namespace Dat.Quiz
{
    public class QuizConsts
    {
        public const string LocalizationSourceName = "Quiz";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "{{DEFAULT_PASS_PHRASE_HERE}}";
    }
}

