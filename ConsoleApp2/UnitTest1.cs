using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryLaba10;
using System;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Plants_EqualProperties()
        {
            //Arrange
            Plants expected = new Plants("Цветок", "Синий", 1);
            // Act
            Plants actual = new Plants("Цветок", "Синий", 1);
            //Assert
            Assert.AreEqual(expected.Name, actual.Name);
            Assert.AreEqual(expected.Color, actual.Color);
            Assert.AreEqual(expected.id, actual.id);
        }
        [TestMethod]
        public void Plants_DifferentProperties() 
        {
            //Arrange
            Plants expected = new Plants("Цветок", "Синий", 1);
            //Act
            Plants actual = new Plants("Дерево", "Красный", -1);
            //Assert
            Assert.AreNotEqual(expected.Name, actual.Name);
            Assert.AreNotEqual(expected.Color, actual.Color);
            Assert.AreNotEqual(expected.id, actual.id);
        }
        [TestMethod]
        public void Plants_DefaultConstructor()
        {
            //Arrange
            Plants expected = new Plants();
            //Act
            Plants actual = new Plants();
            //Assert
            Assert.AreEqual(expected.Name, actual.Name);
            Assert.AreEqual(expected.Color, actual.Color);
            Assert.AreEqual(expected.id, actual.id);
        }
        [TestMethod]
        public void Trees_EqualProperties() 
        {
            Trees expected = new Trees("Дуб", "Синий", 3, 1);
            //Act
            Trees actual = new Trees("Дуб", "Синий", 3, 1);
            //Assert
            Assert.AreEqual(expected.Name, actual.Name);
            Assert.AreEqual(expected.Color, actual.Color);
            Assert.AreEqual(expected.id, actual.id);
            Assert.AreEqual(expected.Height, actual.Height);
        }
        [TestMethod]
        public void Trees_DifferentProperties()
        {
            //Arrange
            Trees expected = new Trees("Дуб", "Синий", 3, 1);
            //Act
            Trees actual = new Trees("Береза", "Красный", 1, 1);
            //Assert
            Assert.AreNotEqual(expected.Name, actual.Name);
            Assert.AreNotEqual(expected.Color, actual.Color);
            Assert.AreEqual(expected.id, actual.id);
            Assert.AreNotEqual(expected.Height, actual.Height);
        }
        [TestMethod]
        public void Trees_DefaultConstructor()
        {
            //Arrange
            Trees expected = new Trees();
            //Act
            Trees actual = new Trees();
            //Assert
            Assert.AreEqual(expected.Name, actual.Name);
            Assert.AreEqual(expected.Color, actual.Color);
            Assert.AreEqual(expected.id, actual.id);
            Assert.AreEqual(expected.Height, actual.Height);
        }
        [TestMethod]
        public void Flowers_EqualProperties() 
        {
            //Arrange
            Flowers expected = new Flowers("Тюльпан", "Синий", "Приятный", 1);
            //Act
            Flowers actual = new Flowers("Тюльпан", "Синий", "Приятный", 1);
            //Assert
            Assert.AreEqual(expected.Name, actual.Name);
            Assert.AreEqual(expected.Color, actual.Color);
            Assert.AreEqual(expected.id, actual.id);
            Assert.AreEqual(expected.Flavor, actual.Flavor);
        }
        [TestMethod]
        public void Flowers_DifferentProperties() 
        {
            //Arrange
            Flowers expected = new Flowers("Тюльпан", "Синий", "Приятный", 1);
            //Act
            Flowers actual = new Flowers("Роза", "Красный", "Густой", -1);
            //Assert
            Assert.AreNotEqual(expected.Name, actual.Name);
            Assert.AreNotEqual(expected.Color, actual.Color);
            Assert.AreNotEqual(expected.id, actual.id);
            Assert.AreNotEqual(expected.Flavor, actual.Flavor);
        }
        [TestMethod]
        public void Flowers_DefaultConstructor() 
        {
            //Arrange
            Flowers expected = new Flowers();
            //Act
            Flowers actual = new Flowers();
            //Assert
            Assert.AreEqual(expected.Name, actual.Name);
            Assert.AreEqual(expected.Color, actual.Color);
            Assert.AreEqual(expected.id, actual.id);
            Assert.AreEqual(expected.Flavor, actual.Flavor);
        }
        [TestMethod]
        public void Rose_DefaultConstructor() 
        {
            //Arrange
            Rose expected = new Rose();
            //Act
            Rose actual = new Rose();
            //Assert
            Assert.AreEqual(expected.Name, actual.Name);
            Assert.AreEqual(expected.Color, actual.Color);
            Assert.AreEqual(expected.id, actual.id);
            Assert.AreEqual(expected.Flavor, actual.Flavor);
            Assert.AreEqual(expected.Thorns, actual.Thorns);
        }
        [TestMethod]
        public void Rose_EqualProperties() 
        {
            //Arrange
            Rose expected = new Rose("Белая роза","Белый" , "Свежий", true, 1);
            //Act
            Rose actual = new Rose("Белая роза", "Белый", "Свежий", true, 1);
            //Assert
            Assert.AreEqual(expected.Name, actual.Name);
            Assert.AreEqual(expected.Color, actual.Color);
            Assert.AreEqual(expected.id, actual.id);
            Assert.AreEqual(expected.Flavor, actual.Flavor);
            Assert.AreEqual(expected.Thorns, actual.Thorns);
        }
        public void Rose_DifferentProperties()
        {
            //Arrange
            Rose expected = new Rose("Белая роза", "Белый", "Свежий", true, 1);
            //Act
            Rose actual = new Rose("Роза Флорибунда", "Красный", "Густой", false, -1);
            //Assert
            Assert.AreNotEqual(expected.Name, actual.Name);
            Assert.AreNotEqual(expected.Color, actual.Color);
            Assert.AreNotEqual(expected.id, actual.id);
            Assert.AreNotEqual(expected.Flavor, actual.Flavor);
            Assert.AreNotEqual(expected.Thorns, actual.Thorns);
        }
        public void Plants_IDZeroOverride()
        {
            //Arrange
            Plants expected = new Plants("Цветок", "Синий", 0);
            // Act
            Plants actual = new Plants("Цветок", "Синий", -1);
            //Assert
            Assert.AreEqual(expected.Name, actual.Name);
            Assert.AreEqual(expected.Color, actual.Color);
            Assert.AreEqual(expected.id, actual.id);
        }
        [TestMethod]
        public void Trees_IDZeroOverride()
        {
            Trees expected = new Trees("Дуб", "Синий", 3, 0);
            //Act
            Trees actual = new Trees("Дуб", "Синий", 3, -1);
            //Assert
            Assert.AreEqual(expected.Name, actual.Name);
            Assert.AreEqual(expected.Color, actual.Color);
            Assert.AreEqual(expected.id, actual.id);
            Assert.AreEqual(expected.Height, actual.Height);
        }
        [TestMethod]
        public void Flowers_IDZeroOverride()
        {
            //Arrange
            Flowers expected = new Flowers("Тюльпан", "Синий", "Приятный", 0);
            //Act
            Flowers actual = new Flowers("Тюльпан", "Синий", "Приятный", -1);
            //Assert
            Assert.AreEqual(expected.Name, actual.Name);
            Assert.AreEqual(expected.Color, actual.Color);
            Assert.AreEqual(expected.id, actual.id);
            Assert.AreEqual(expected.Flavor, actual.Flavor);
        }
        [TestMethod]
        public void Rose_IDZeroOverride() 
        {
            //Arrange
            Rose expected = new Rose("Белая роза", "Белый", "Свежий", true, 0);
            //Act
            Rose actual = new Rose("Белая роза", "Белый", "Свежий", true, -1);
            //Assert
            Assert.AreEqual(expected.Name, actual.Name);
            Assert.AreEqual(expected.Color, actual.Color);
            Assert.AreEqual(expected.id, actual.id);
            Assert.AreEqual(expected.Flavor, actual.Flavor);
            Assert.AreEqual(expected.Thorns, actual.Thorns);
        }
        [TestMethod]
        public void Plants_EqualsTrue() 
        {
            // Arrange
            Plants plant1 = new Plants("Цветок", "Красный", 1);
            Plants plant2 = new Plants("Цветок", "Красный", 1);

            // Act
            bool result = plant1.Equals(plant2);

            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Plants_EqualsFalse()
        {
            // Arrange
            Plants plant1 = new Plants("Дерево", "Зеленый", 1);
            Plants plant2 = new Plants("Цветок", "Желтый", 2);

            // Act
            bool result = plant1.Equals(plant2);

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void Trees_EqualsTrue()
        {
            // Arrange
            Trees trees1 = new Trees();
            Trees trees2 = new Trees();

            // Act
            bool result = trees1.Equals(trees2);

            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Trees_EqualsFalse() 
        {
            Trees trees1 = new Trees("Дуб", "Синий", 3, 0);
            Trees trees2 = new Trees("Береза", "Красный", 1, 1);

            // Act
            bool result = trees1.Equals(trees2);

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void Flowers_EqualsTrue() 
        {
            // Arrange
            Flowers flower1 = new Flowers();
            Flowers flower2 = new Flowers();

            // Act
            bool result = flower1.Equals(flower2);

            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Flowers_EqualsFalse() 
        {
            // Arrange
            Flowers flower1 = new Flowers("Белая роза", "Белый", "Свежий", 0);
            Flowers flower2 = new Flowers("Тюльпан", "Синий", "Приятный", 0);

            // Act
            bool result = flower1.Equals(flower2);

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void Rose_EqualsTrue() 
        {
            // Arrange
            Rose rose1 = new Rose();
            Rose rose2 = new Rose();

            // Act
            bool result = rose1.Equals(rose2);

            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Rose_EqualsFalse()
        {
            // Arrange
            Rose rose1 = new Rose("Белая роза", "Белый", "Свежий", true, 0);
            Rose rose2 = new Rose("Роза Флорибунда", "Красный", "Густой", false, -1);

            // Act
            bool result = rose1.Equals(rose2);

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void Post_ZeroOverride()
        {
            //Arrange
            Post expected = new Post(0, 0, 0);
            //Act
            Post actual = new Post(-1, -1, -1);
            //Assert
            Assert.AreEqual(expected.NumComments, actual.NumComments);
            Assert.AreEqual(expected.NumViews, actual.NumViews);
            Assert.AreEqual(expected.NumReactions, actual.NumReactions);
        }
        [TestMethod]
        public void Post_EqualProperties()
        {
            //Arrange
            Post expected = new Post(100, 300, 35);
            //Act

            Post actual = new Post(100, 300, 35);
            //Assert
            Assert.AreEqual(expected.NumComments, actual.NumComments);
            Assert.AreEqual(expected.NumViews, actual.NumViews);
            Assert.AreEqual(expected.NumReactions, actual.NumReactions);
        }
        [TestMethod]
        public void Post_DefaultConstructor()
        {
            //Arrange
            Post expected = new Post();
            //Act
            Post actual = new Post();
            //Assert
            Assert.AreEqual(expected.NumComments, actual.NumComments);
            Assert.AreEqual(expected.NumViews, actual.NumViews);
            Assert.AreEqual(expected.NumReactions, actual.NumReactions);
        }
        [TestMethod]
        public void Post_EqualsTrue() 
        {
            // Arrange
            Post post1 = new Post
            {
                NumViews = 100,
                NumComments = 50,
                NumReactions = 20
            };
            Post post2 = new Post
            {
                NumViews = 100,
                NumComments = 50,
                NumReactions = 20
            };
            // Act
            bool result = post1.Equals(post2);
            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Post_EqualsFalse() 
        {
            // Arrange
            Post post1 = new Post
            {
                NumViews = 100,
                NumComments = 50,
                NumReactions = 20
            };
            Post post2 = new Post
            {
                NumViews = 200,
                NumComments = 50,
                NumReactions = 20
            };
            // Act
            bool result = post1.Equals(post2);
            // Assert
            Assert.IsFalse(result);
        }
    }
}
