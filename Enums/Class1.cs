using System.ComponentModel;
using System.Reflection;

namespace Enums;

public class Class1
{
    /*
     * Создайте перечисление для дней недели и напишите метод, который принимает день недели и выводит, является ли этот день рабочим или выходным.
     */

    enum DaysOfWeek
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    public static bool IsWeekend(int day)
    {
        if (day == (int)DaysOfWeek.Saturday || day == (int)DaysOfWeek.Sunday)
            return true;
        return false;
    }
    
    /* Создайте перечисление для уровней доступа пользователей и напишите метод, который будет возвращать разрешения на основе уровня доступа. */

    public enum AccessLevel
    {
        Guest,
        Moderator,
        User,
        Admin
    }
    
    public static string? GetPermissions(AccessLevel accessLevel)
    {
        return accessLevel switch
        {
            AccessLevel.Admin => "All",
            AccessLevel.Guest => "Read",
            AccessLevel.User => "Comment Post",
            AccessLevel.Moderator => "Create Post",
            _ => null
        };
    }
    
    /*Создайте перечисление для статусов заказа с использованием атрибута Description для каждого значения. Напишите метод, который будет возвращать описание статуса заказа.*/

    enum OrderStatus
    {
        [Description("The order has just been created and is awaiting processing")]
        New,
        [Description("The order has been accepted and is under review by the staff.")]
        Processing,
        [Description("Payment for the order has been successfully received")]
        Paid,
        [Description("The order has been packed and is ready to be shipped to the customer.")]
        Ready,
        [Description("The order is in the process of being delivered to the customer")]
        Out,
        [Description("The order has been successfully delivered and paid for")]
        Completed
    }

    public static string GetOrderDescription(int num)
    {
        return GetEnumDescription((OrderStatus)num);
    }

    private static string GetEnumDescription(Enum value)
    {
        FieldInfo? fi = value.GetType().GetField(value.ToString());

        DescriptionAttribute[] attributes = fi.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

        if (attributes != null && attributes.Any())
        {
            return attributes.First().Description;
        }

        

        return value.ToString();
    }

    [Flags]
    public enum AccessRight
    {
        None = 0,
        Read = 0b_001,
        Write = 0b_010,
        Delete = 0b_100,
        User = AccessRight.Read | AccessRight.Write,
        Admin = AccessRight.Read | AccessRight.Write | AccessRight.Delete,
        Guest = AccessRight.Read
    }
}