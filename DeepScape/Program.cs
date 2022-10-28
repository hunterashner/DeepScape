using System;
using static Tensorflow.Binding;

class Program
{
    public static void Main(String[] args)
    {
        var testing = tf.constant("Hello, TensorFlow!");
        Console.WriteLine(testing);
    }
}
