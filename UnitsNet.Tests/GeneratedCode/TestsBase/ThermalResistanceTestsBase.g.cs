//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using System.Globalization;
using System.Linq;
using System.Threading;
using UnitsNet.Tests.TestsBase;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of ThermalResistance.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ThermalResistanceTestsBase : QuantityTestsBase
    {
        protected abstract double HourSquareFeetDegreesFahrenheitPerBtuInOneSquareMeterKelvinPerKilowatt { get; }
        protected abstract double SquareCentimeterHourDegreesCelsiusPerKilocalorieInOneSquareMeterKelvinPerKilowatt { get; }
        protected abstract double SquareCentimeterKelvinsPerWattInOneSquareMeterKelvinPerKilowatt { get; }
        protected abstract double SquareMeterDegreesCelsiusPerWattInOneSquareMeterKelvinPerKilowatt { get; }
        protected abstract double SquareMeterKelvinsPerKilowattInOneSquareMeterKelvinPerKilowatt { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double HourSquareFeetDegreesFahrenheitPerBtuTolerance { get { return 1e-5; } }
        protected virtual double SquareCentimeterHourDegreesCelsiusPerKilocalorieTolerance { get { return 1e-5; } }
        protected virtual double SquareCentimeterKelvinsPerWattTolerance { get { return 1e-5; } }
        protected virtual double SquareMeterDegreesCelsiusPerWattTolerance { get { return 1e-5; } }
        protected virtual double SquareMeterKelvinsPerKilowattTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ThermalResistance((double)0.0, ThermalResistanceUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new ThermalResistance();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(ThermalResistanceUnit.SquareMeterKelvinPerKilowatt, quantity.Unit);
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ThermalResistance(double.PositiveInfinity, ThermalResistanceUnit.SquareMeterKelvinPerKilowatt));
            Assert.Throws<ArgumentException>(() => new ThermalResistance(double.NegativeInfinity, ThermalResistanceUnit.SquareMeterKelvinPerKilowatt));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ThermalResistance(double.NaN, ThermalResistanceUnit.SquareMeterKelvinPerKilowatt));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new ThermalResistance(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new ThermalResistance(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (ThermalResistance) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void ThermalResistance_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new ThermalResistance(1, ThermalResistanceUnit.SquareMeterKelvinPerKilowatt);

            QuantityInfo<ThermalResistanceUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(ThermalResistance.Zero, quantityInfo.Zero);
            Assert.Equal("ThermalResistance", quantityInfo.Name);

            var units = EnumUtils.GetEnumValues<ThermalResistanceUnit>().Except(new[] {ThermalResistanceUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

            // Obsolete members
            Assert.Equal(units, quantityInfo.Units);
            Assert.Equal(unitNames, quantityInfo.UnitNames);
        }

        [Fact]
        public void SquareMeterKelvinPerKilowattToThermalResistanceUnits()
        {
            ThermalResistance squaremeterkelvinperkilowatt = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1);
            AssertEx.EqualTolerance(HourSquareFeetDegreesFahrenheitPerBtuInOneSquareMeterKelvinPerKilowatt, squaremeterkelvinperkilowatt.HourSquareFeetDegreesFahrenheitPerBtu, HourSquareFeetDegreesFahrenheitPerBtuTolerance);
            AssertEx.EqualTolerance(SquareCentimeterHourDegreesCelsiusPerKilocalorieInOneSquareMeterKelvinPerKilowatt, squaremeterkelvinperkilowatt.SquareCentimeterHourDegreesCelsiusPerKilocalorie, SquareCentimeterHourDegreesCelsiusPerKilocalorieTolerance);
            AssertEx.EqualTolerance(SquareCentimeterKelvinsPerWattInOneSquareMeterKelvinPerKilowatt, squaremeterkelvinperkilowatt.SquareCentimeterKelvinsPerWatt, SquareCentimeterKelvinsPerWattTolerance);
            AssertEx.EqualTolerance(SquareMeterDegreesCelsiusPerWattInOneSquareMeterKelvinPerKilowatt, squaremeterkelvinperkilowatt.SquareMeterDegreesCelsiusPerWatt, SquareMeterDegreesCelsiusPerWattTolerance);
            AssertEx.EqualTolerance(SquareMeterKelvinsPerKilowattInOneSquareMeterKelvinPerKilowatt, squaremeterkelvinperkilowatt.SquareMeterKelvinsPerKilowatt, SquareMeterKelvinsPerKilowattTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = ThermalResistance.From(1, ThermalResistanceUnit.HourSquareFeetDegreeFahrenheitPerBtu);
            AssertEx.EqualTolerance(1, quantity00.HourSquareFeetDegreesFahrenheitPerBtu, HourSquareFeetDegreesFahrenheitPerBtuTolerance);
            Assert.Equal(ThermalResistanceUnit.HourSquareFeetDegreeFahrenheitPerBtu, quantity00.Unit);

            var quantity01 = ThermalResistance.From(1, ThermalResistanceUnit.SquareCentimeterHourDegreeCelsiusPerKilocalorie);
            AssertEx.EqualTolerance(1, quantity01.SquareCentimeterHourDegreesCelsiusPerKilocalorie, SquareCentimeterHourDegreesCelsiusPerKilocalorieTolerance);
            Assert.Equal(ThermalResistanceUnit.SquareCentimeterHourDegreeCelsiusPerKilocalorie, quantity01.Unit);

            var quantity02 = ThermalResistance.From(1, ThermalResistanceUnit.SquareCentimeterKelvinPerWatt);
            AssertEx.EqualTolerance(1, quantity02.SquareCentimeterKelvinsPerWatt, SquareCentimeterKelvinsPerWattTolerance);
            Assert.Equal(ThermalResistanceUnit.SquareCentimeterKelvinPerWatt, quantity02.Unit);

            var quantity03 = ThermalResistance.From(1, ThermalResistanceUnit.SquareMeterDegreeCelsiusPerWatt);
            AssertEx.EqualTolerance(1, quantity03.SquareMeterDegreesCelsiusPerWatt, SquareMeterDegreesCelsiusPerWattTolerance);
            Assert.Equal(ThermalResistanceUnit.SquareMeterDegreeCelsiusPerWatt, quantity03.Unit);

            var quantity04 = ThermalResistance.From(1, ThermalResistanceUnit.SquareMeterKelvinPerKilowatt);
            AssertEx.EqualTolerance(1, quantity04.SquareMeterKelvinsPerKilowatt, SquareMeterKelvinsPerKilowattTolerance);
            Assert.Equal(ThermalResistanceUnit.SquareMeterKelvinPerKilowatt, quantity04.Unit);

        }

        [Fact]
        public void FromSquareMeterKelvinsPerKilowatt_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ThermalResistance.FromSquareMeterKelvinsPerKilowatt(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => ThermalResistance.FromSquareMeterKelvinsPerKilowatt(double.NegativeInfinity));
        }

        [Fact]
        public void FromSquareMeterKelvinsPerKilowatt_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ThermalResistance.FromSquareMeterKelvinsPerKilowatt(double.NaN));
        }

        [Fact]
        public void As()
        {
            var squaremeterkelvinperkilowatt = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1);
            AssertEx.EqualTolerance(HourSquareFeetDegreesFahrenheitPerBtuInOneSquareMeterKelvinPerKilowatt, squaremeterkelvinperkilowatt.As(ThermalResistanceUnit.HourSquareFeetDegreeFahrenheitPerBtu), HourSquareFeetDegreesFahrenheitPerBtuTolerance);
            AssertEx.EqualTolerance(SquareCentimeterHourDegreesCelsiusPerKilocalorieInOneSquareMeterKelvinPerKilowatt, squaremeterkelvinperkilowatt.As(ThermalResistanceUnit.SquareCentimeterHourDegreeCelsiusPerKilocalorie), SquareCentimeterHourDegreesCelsiusPerKilocalorieTolerance);
            AssertEx.EqualTolerance(SquareCentimeterKelvinsPerWattInOneSquareMeterKelvinPerKilowatt, squaremeterkelvinperkilowatt.As(ThermalResistanceUnit.SquareCentimeterKelvinPerWatt), SquareCentimeterKelvinsPerWattTolerance);
            AssertEx.EqualTolerance(SquareMeterDegreesCelsiusPerWattInOneSquareMeterKelvinPerKilowatt, squaremeterkelvinperkilowatt.As(ThermalResistanceUnit.SquareMeterDegreeCelsiusPerWatt), SquareMeterDegreesCelsiusPerWattTolerance);
            AssertEx.EqualTolerance(SquareMeterKelvinsPerKilowattInOneSquareMeterKelvinPerKilowatt, squaremeterkelvinperkilowatt.As(ThermalResistanceUnit.SquareMeterKelvinPerKilowatt), SquareMeterKelvinsPerKilowattTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new ThermalResistance(value: 1, unit: ThermalResistance.ConversionBaseUnit);
            Func<object> AsWithSIUnitSystem = () => quantity.As(UnitSystem.SI);

            if (SupportsSIUnitSystem)
            {
                var value = (double) AsWithSIUnitSystem();
                Assert.Equal(1, value);
            }
            else
            {
                Assert.Throws<ArgumentException>(AsWithSIUnitSystem);
            }
        }

        [Fact]
        public void ToUnit()
        {
            var squaremeterkelvinperkilowatt = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1);

            var hoursquarefeetdegreefahrenheitperbtuQuantity = squaremeterkelvinperkilowatt.ToUnit(ThermalResistanceUnit.HourSquareFeetDegreeFahrenheitPerBtu);
            AssertEx.EqualTolerance(HourSquareFeetDegreesFahrenheitPerBtuInOneSquareMeterKelvinPerKilowatt, (double)hoursquarefeetdegreefahrenheitperbtuQuantity.Value, HourSquareFeetDegreesFahrenheitPerBtuTolerance);
            Assert.Equal(ThermalResistanceUnit.HourSquareFeetDegreeFahrenheitPerBtu, hoursquarefeetdegreefahrenheitperbtuQuantity.Unit);

            var squarecentimeterhourdegreecelsiusperkilocalorieQuantity = squaremeterkelvinperkilowatt.ToUnit(ThermalResistanceUnit.SquareCentimeterHourDegreeCelsiusPerKilocalorie);
            AssertEx.EqualTolerance(SquareCentimeterHourDegreesCelsiusPerKilocalorieInOneSquareMeterKelvinPerKilowatt, (double)squarecentimeterhourdegreecelsiusperkilocalorieQuantity.Value, SquareCentimeterHourDegreesCelsiusPerKilocalorieTolerance);
            Assert.Equal(ThermalResistanceUnit.SquareCentimeterHourDegreeCelsiusPerKilocalorie, squarecentimeterhourdegreecelsiusperkilocalorieQuantity.Unit);

            var squarecentimeterkelvinperwattQuantity = squaremeterkelvinperkilowatt.ToUnit(ThermalResistanceUnit.SquareCentimeterKelvinPerWatt);
            AssertEx.EqualTolerance(SquareCentimeterKelvinsPerWattInOneSquareMeterKelvinPerKilowatt, (double)squarecentimeterkelvinperwattQuantity.Value, SquareCentimeterKelvinsPerWattTolerance);
            Assert.Equal(ThermalResistanceUnit.SquareCentimeterKelvinPerWatt, squarecentimeterkelvinperwattQuantity.Unit);

            var squaremeterdegreecelsiusperwattQuantity = squaremeterkelvinperkilowatt.ToUnit(ThermalResistanceUnit.SquareMeterDegreeCelsiusPerWatt);
            AssertEx.EqualTolerance(SquareMeterDegreesCelsiusPerWattInOneSquareMeterKelvinPerKilowatt, (double)squaremeterdegreecelsiusperwattQuantity.Value, SquareMeterDegreesCelsiusPerWattTolerance);
            Assert.Equal(ThermalResistanceUnit.SquareMeterDegreeCelsiusPerWatt, squaremeterdegreecelsiusperwattQuantity.Unit);

            var squaremeterkelvinperkilowattQuantity = squaremeterkelvinperkilowatt.ToUnit(ThermalResistanceUnit.SquareMeterKelvinPerKilowatt);
            AssertEx.EqualTolerance(SquareMeterKelvinsPerKilowattInOneSquareMeterKelvinPerKilowatt, (double)squaremeterkelvinperkilowattQuantity.Value, SquareMeterKelvinsPerKilowattTolerance);
            Assert.Equal(ThermalResistanceUnit.SquareMeterKelvinPerKilowatt, squaremeterkelvinperkilowattQuantity.Unit);
        }

        [Fact]
        public void ToBaseUnit_ReturnsQuantityWithBaseUnit()
        {
            var quantityInBaseUnit = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1).ToBaseUnit();
            Assert.Equal(ThermalResistance.ConversionBaseUnit, quantityInBaseUnit.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            ThermalResistance squaremeterkelvinperkilowatt = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1);
            AssertEx.EqualTolerance(1, ThermalResistance.FromHourSquareFeetDegreesFahrenheitPerBtu(squaremeterkelvinperkilowatt.HourSquareFeetDegreesFahrenheitPerBtu).SquareMeterKelvinsPerKilowatt, HourSquareFeetDegreesFahrenheitPerBtuTolerance);
            AssertEx.EqualTolerance(1, ThermalResistance.FromSquareCentimeterHourDegreesCelsiusPerKilocalorie(squaremeterkelvinperkilowatt.SquareCentimeterHourDegreesCelsiusPerKilocalorie).SquareMeterKelvinsPerKilowatt, SquareCentimeterHourDegreesCelsiusPerKilocalorieTolerance);
            AssertEx.EqualTolerance(1, ThermalResistance.FromSquareCentimeterKelvinsPerWatt(squaremeterkelvinperkilowatt.SquareCentimeterKelvinsPerWatt).SquareMeterKelvinsPerKilowatt, SquareCentimeterKelvinsPerWattTolerance);
            AssertEx.EqualTolerance(1, ThermalResistance.FromSquareMeterDegreesCelsiusPerWatt(squaremeterkelvinperkilowatt.SquareMeterDegreesCelsiusPerWatt).SquareMeterKelvinsPerKilowatt, SquareMeterDegreesCelsiusPerWattTolerance);
            AssertEx.EqualTolerance(1, ThermalResistance.FromSquareMeterKelvinsPerKilowatt(squaremeterkelvinperkilowatt.SquareMeterKelvinsPerKilowatt).SquareMeterKelvinsPerKilowatt, SquareMeterKelvinsPerKilowattTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            ThermalResistance v = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1);
            AssertEx.EqualTolerance(-1, -v.SquareMeterKelvinsPerKilowatt, SquareMeterKelvinsPerKilowattTolerance);
            AssertEx.EqualTolerance(2, (ThermalResistance.FromSquareMeterKelvinsPerKilowatt(3)-v).SquareMeterKelvinsPerKilowatt, SquareMeterKelvinsPerKilowattTolerance);
            AssertEx.EqualTolerance(2, (v + v).SquareMeterKelvinsPerKilowatt, SquareMeterKelvinsPerKilowattTolerance);
            AssertEx.EqualTolerance(10, (v*10).SquareMeterKelvinsPerKilowatt, SquareMeterKelvinsPerKilowattTolerance);
            AssertEx.EqualTolerance(10, (10*v).SquareMeterKelvinsPerKilowatt, SquareMeterKelvinsPerKilowattTolerance);
            AssertEx.EqualTolerance(2, (ThermalResistance.FromSquareMeterKelvinsPerKilowatt(10)/5).SquareMeterKelvinsPerKilowatt, SquareMeterKelvinsPerKilowattTolerance);
            AssertEx.EqualTolerance(2, ThermalResistance.FromSquareMeterKelvinsPerKilowatt(10)/ThermalResistance.FromSquareMeterKelvinsPerKilowatt(5), SquareMeterKelvinsPerKilowattTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            ThermalResistance oneSquareMeterKelvinPerKilowatt = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1);
            ThermalResistance twoSquareMeterKelvinsPerKilowatt = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(2);

            Assert.True(oneSquareMeterKelvinPerKilowatt < twoSquareMeterKelvinsPerKilowatt);
            Assert.True(oneSquareMeterKelvinPerKilowatt <= twoSquareMeterKelvinsPerKilowatt);
            Assert.True(twoSquareMeterKelvinsPerKilowatt > oneSquareMeterKelvinPerKilowatt);
            Assert.True(twoSquareMeterKelvinsPerKilowatt >= oneSquareMeterKelvinPerKilowatt);

            Assert.False(oneSquareMeterKelvinPerKilowatt > twoSquareMeterKelvinsPerKilowatt);
            Assert.False(oneSquareMeterKelvinPerKilowatt >= twoSquareMeterKelvinsPerKilowatt);
            Assert.False(twoSquareMeterKelvinsPerKilowatt < oneSquareMeterKelvinPerKilowatt);
            Assert.False(twoSquareMeterKelvinsPerKilowatt <= oneSquareMeterKelvinPerKilowatt);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            ThermalResistance squaremeterkelvinperkilowatt = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1);
            Assert.Equal(0, squaremeterkelvinperkilowatt.CompareTo(squaremeterkelvinperkilowatt));
            Assert.True(squaremeterkelvinperkilowatt.CompareTo(ThermalResistance.Zero) > 0);
            Assert.True(ThermalResistance.Zero.CompareTo(squaremeterkelvinperkilowatt) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            ThermalResistance squaremeterkelvinperkilowatt = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1);
            Assert.Throws<ArgumentException>(() => squaremeterkelvinperkilowatt.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            ThermalResistance squaremeterkelvinperkilowatt = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1);
            Assert.Throws<ArgumentNullException>(() => squaremeterkelvinperkilowatt.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1);
            var b = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(2);

#pragma warning disable CS8073
// ReSharper disable EqualExpressionComparison

            Assert.True(a == a);
            Assert.False(a != a);

            Assert.True(a != b);
            Assert.False(a == b);

            Assert.False(a == null);
            Assert.False(null == a);

// ReSharper restore EqualExpressionComparison
#pragma warning restore CS8073
        }

        [Fact]
        public void Equals_SameType_IsImplemented()
        {
            var a = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1);
            var b = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
        }

        [Fact]
        public void Equals_QuantityAsObject_IsImplemented()
        {
            object a = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1);
            object b = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals((object)null));
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1);
            Assert.True(v.Equals(ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1), SquareMeterKelvinsPerKilowattTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(ThermalResistance.Zero, SquareMeterKelvinsPerKilowattTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            ThermalResistance squaremeterkelvinperkilowatt = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1);
            Assert.False(squaremeterkelvinperkilowatt.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            ThermalResistance squaremeterkelvinperkilowatt = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1);
            Assert.False(squaremeterkelvinperkilowatt.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(ThermalResistanceUnit.Undefined, ThermalResistance.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(ThermalResistanceUnit)).Cast<ThermalResistanceUnit>();
            foreach(var unit in units)
            {
                if(unit == ThermalResistanceUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(ThermalResistance.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 Hrft²°F/Btu", new ThermalResistance(1, ThermalResistanceUnit.HourSquareFeetDegreeFahrenheitPerBtu).ToString());
                Assert.Equal("1 cm²Hr°C/kcal", new ThermalResistance(1, ThermalResistanceUnit.SquareCentimeterHourDegreeCelsiusPerKilocalorie).ToString());
                Assert.Equal("1 cm²K/W", new ThermalResistance(1, ThermalResistanceUnit.SquareCentimeterKelvinPerWatt).ToString());
                Assert.Equal("1 m²°C/W", new ThermalResistance(1, ThermalResistanceUnit.SquareMeterDegreeCelsiusPerWatt).ToString());
                Assert.Equal("1 m²K/kW", new ThermalResistance(1, ThermalResistanceUnit.SquareMeterKelvinPerKilowatt).ToString());
            }
            finally
            {
                Thread.CurrentThread.CurrentUICulture = prevCulture;
            }
        }

        [Fact]
        public void ToString_WithSwedishCulture_ReturnsUnitAbbreviationForEnglishCultureSinceThereAreNoMappings()
        {
            // Chose this culture, because we don't currently have any abbreviations mapped for that culture and we expect the en-US to be used as fallback.
            var swedishCulture = CultureInfo.GetCultureInfo("sv-SE");

            Assert.Equal("1 Hrft²°F/Btu", new ThermalResistance(1, ThermalResistanceUnit.HourSquareFeetDegreeFahrenheitPerBtu).ToString(swedishCulture));
            Assert.Equal("1 cm²Hr°C/kcal", new ThermalResistance(1, ThermalResistanceUnit.SquareCentimeterHourDegreeCelsiusPerKilocalorie).ToString(swedishCulture));
            Assert.Equal("1 cm²K/W", new ThermalResistance(1, ThermalResistanceUnit.SquareCentimeterKelvinPerWatt).ToString(swedishCulture));
            Assert.Equal("1 m²°C/W", new ThermalResistance(1, ThermalResistanceUnit.SquareMeterDegreeCelsiusPerWatt).ToString(swedishCulture));
            Assert.Equal("1 m²K/kW", new ThermalResistance(1, ThermalResistanceUnit.SquareMeterKelvinPerKilowatt).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 m²K/kW", new ThermalResistance(0.123456, ThermalResistanceUnit.SquareMeterKelvinPerKilowatt).ToString("s1"));
                Assert.Equal("0.12 m²K/kW", new ThermalResistance(0.123456, ThermalResistanceUnit.SquareMeterKelvinPerKilowatt).ToString("s2"));
                Assert.Equal("0.123 m²K/kW", new ThermalResistance(0.123456, ThermalResistanceUnit.SquareMeterKelvinPerKilowatt).ToString("s3"));
                Assert.Equal("0.1235 m²K/kW", new ThermalResistance(0.123456, ThermalResistanceUnit.SquareMeterKelvinPerKilowatt).ToString("s4"));
            }
            finally
            {
                CultureInfo.CurrentUICulture = oldCulture;
            }
        }

        [Fact]
        public void ToString_SFormatAndCulture_FormatsNumberWithGivenDigitsAfterRadixForGivenCulture()
        {
            var culture = CultureInfo.InvariantCulture;
            Assert.Equal("0.1 m²K/kW", new ThermalResistance(0.123456, ThermalResistanceUnit.SquareMeterKelvinPerKilowatt).ToString("s1", culture));
            Assert.Equal("0.12 m²K/kW", new ThermalResistance(0.123456, ThermalResistanceUnit.SquareMeterKelvinPerKilowatt).ToString("s2", culture));
            Assert.Equal("0.123 m²K/kW", new ThermalResistance(0.123456, ThermalResistanceUnit.SquareMeterKelvinPerKilowatt).ToString("s3", culture));
            Assert.Equal("0.1235 m²K/kW", new ThermalResistance(0.123456, ThermalResistanceUnit.SquareMeterKelvinPerKilowatt).ToString("s4", culture));
        }

        [Fact]
        public void ToString_NullFormat_ThrowsArgumentNullException()
        {
            var quantity = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, null, null));
        }

        [Fact]
        public void ToString_NullArgs_ThrowsArgumentNullException()
        {
            var quantity = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, "g", null));
        }

        [Fact]
        public void ToString_NullProvider_EqualsCurrentUICulture()
        {
            var quantity = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1.0);
            Assert.Equal(quantity.ToString(CultureInfo.CurrentUICulture, "g"), quantity.ToString(null, "g"));
        }

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(ThermalResistance)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(ThermalResistanceUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1.0);
            Assert.Equal(ThermalResistance.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1.0);
            Assert.Equal(ThermalResistance.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1.0);
            Assert.Equal(new {ThermalResistance.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(value);
            Assert.Equal(ThermalResistance.FromSquareMeterKelvinsPerKilowatt(-value), -quantity);
        }
    }
}
