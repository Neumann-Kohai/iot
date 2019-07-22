﻿namespace Iot.Device.Bmxx80.Register
{
    /// <summary>
    /// General control registers for the BME280.
    /// </summary>
    internal enum Bme280Register : byte
    {
        CTRL_HUM = 0xF2,

        DIG_H1 = 0xA1,
        DIG_H2 = 0xE1,
        DIG_H3 = 0xE3,
        DIG_H4 = 0xE4,
        DIG_H5 = 0xE5,
        DIG_H6 = 0xE7,

        HUMIDDATA_LSB = 0xFE,
        HUMIDDATA_MSB = 0xFD,
    }
}
