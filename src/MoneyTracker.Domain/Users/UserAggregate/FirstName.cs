﻿using System.ComponentModel.DataAnnotations.Schema;

namespace MoneyTracker.Domain.Users.UserAggregate;

[ComplexType]
public record FirstName(string Value);