﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DateTimeExpression.cs" company="WildGums">
//   Copyright (c) 2008 - 2014 WildGums. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Orc.FilterBuilder
{
    using System;
    using System.Diagnostics;
    using System.Runtime.Serialization;

    [DebuggerDisplay("{ValueControlType} {SelectedCondition} {Value}")]
    [Serializable]
    public class DateTimeExpression : ValueDataTypeExpression<DateTime>
    {
        #region Constructors
        protected DateTimeExpression(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public DateTimeExpression()
            : this(true)
        {
        }

        public DateTimeExpression(bool isNullable)
        {
            IsNullable = isNullable;
            Value = DateTime.Now;
            ValueControlType = ValueControlType.DateTime;
        }
        #endregion
    }
}
