using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Snake.ViewModels;

namespace Snake.AttachedBehavior
{
    public static class CommandBehavior
    {
        public static ICommand GetCommand(DependencyObject obj)
        {
            return (ICommand)obj.GetValue(CommandProperty);
        }

        public static void SetCommand(DependencyObject obj, ICommand value)
        {
            obj.SetValue(CommandProperty, value);
        }

        public static readonly DependencyProperty CommandProperty =
            DependencyProperty.RegisterAttached("Command",
                typeof(ICommand),
                typeof(CommandBehavior),
                new PropertyMetadata(null,
                    new PropertyChangedCallback(HandleCommand)));

        private static void HandleCommand(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as UIElement;

            if (control == null)
            {
                return;
            }

            if ((e.NewValue != null) && (e.OldValue == null))
            {
                control.KeyDown += (sender, args) =>
                {
                    var command = (sender as UIElement).GetValue(CommandBehavior.CommandProperty) as ICommand;
                    if (args.Key == Key.Up)
                    {
                        command.Execute(Direction.Up);
                    }
                    else if (args.Key == Key.Left)
                    {
                        command.Execute(Direction.Left);
                    }
                    else if (args.Key == Key.Right)
                    {
                        command.Execute(Direction.Right);
                    }
                    else if (args.Key == Key.Down)
                    {
                        command.Execute(Direction.Down);
                    }
                    else if (args.Key == Key.E)
                    {
                        command.Execute("Eat");
                    }
                };
            }
        }
    }
}