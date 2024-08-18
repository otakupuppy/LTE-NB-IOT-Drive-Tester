
# Solutions to Mid Trimester Exam

## Question 1: 
Identify the conic, determine the standard equation, center, vertices, foci, and provide a sketch for the equation 2x^2^ + 4y^2^ + 8x - 24y + 36 = 0.

### Solution:
1. **Identify the Conic**:
    - Given equation: 2x^2^ + 4y^2^ + 8x - 24y + 36 = 0
    - Dividing the equation by 2: x^2^ + 2y^2^ + 4x - 12y + 18 = 0
    - This is an ellipse.

2. **Convert to Standard Form**:
    - Group terms: (x^2^ + 4x) + (2y^2^ - 12y) = -18
    - Complete the square: (x + 2)^2^ - 4 + 2(y - 3)^2^ - 18 = -18
    - Simplify: (x + 2)^2^ + 2(y - 3)^2^ = 40
    - Divide by 40: (x + 2)^2^/40 + (y - 3)^2^/20 = 1
    - Standard Form: (x + 2)^2^/40 + (y - 3)^2^/20 = 1

3. **Key Features**:
    - Center: (-2, 3)
    - Vertices: (-2 ± √40, 3) and (-2, 3 ± √20)
    - Foci: (-2 ± √20, 3)
    - The ellipse has a horizontal major axis.

4. **Sketch**:
    - A sketch would show an ellipse centered at (-2, 3) with the major axis horizontal and vertices at (-2 ± 6.32, 3) and minor vertices at (-2, 3 ± 4.47).

---

## Question 2(a):
Express the following complex number in Cartesian/rectangular form:

$$
4e^{\left(\frac{\pi}{2}\right) \left(-2 - \frac{j}{2}\right)}
$$

### Solution 2(a):
Given: 
$$
4e^{\left(\frac{\pi}{2}\right) \left(-2 - \frac{j}{2}\right)}
$$

This can be expanded as:
$$
4e^{\left(\frac{\pi}{2}(-2)\right)} \cdot e^{\left(\frac{\pi}{2} \cdot \frac{-j}{2}\right)}
$$
Simplifying further:
$$
4e^{-\pi} \cdot e^{-\frac{\pi j}{4}}
$$

Now, express each component in Cartesian form:

1. **First component:**
   $$
   e^{-\pi} \text{ is a real number, so } 4e^{-\pi} \text{ remains as is.}
   $$

2. **Second component using Euler's formula:**
   $$
   e^{-\frac{\pi j}{4}} = \cos\left(-\frac{\pi}{4}\right) + j\sin\left(-\frac{\pi}{4}\right)
   $$

   Simplifying the trigonometric values:
   $$
   \cos\left(-\frac{\pi}{4}\right) = \frac{\sqrt{2}}{2}, \quad \sin\left(-\frac{\pi}{4}\right) = -\frac{\sqrt{2}}{2}
   $$

   Therefore:
   $$
   e^{-\frac{\pi j}{4}} = \frac{\sqrt{2}}{2} - j\frac{\sqrt{2}}{2}
   $$

3. **Combine the results:**
   $$
   z = 4e^{-\pi} \cdot \left(\frac{\sqrt{2}}{2} - j\frac{\sqrt{2}}{2}\right)
   $$
   Distribute \( 4e^{-\pi} \):
   $$
   z = 2\sqrt{2}e^{-\pi} - j2\sqrt{2}e^{-\pi}
   $$

So, the Cartesian form of the given expression is:
$$
z = 2\sqrt{2}e^{-\pi} - j2\sqrt{2}e^{-\pi}
$$

---

## Question 2(b): 
Raise the complex number (-3 + j) to the power 6.

### Solution:
1. Convert (-3 + j) to polar form:
    - r = √^((-3)^2^ + 1^2^)^ = √10
    - θ = tan^(-1)(1/-3)^
    - z = √10 * e^jθ^

2. Raise to the power 6:
    - z^6^ = (√10)^6^ * e^j6θ^

3. Convert back to Cartesian form.

---

## Question 3:
Find the derivative of the function y = 5e^cos(x)^ / tanh^(-1)(x^4^ + 10)^.

### Solution:
1. Use the quotient rule:
    - y' = [tanh^(-1)(x^4^ + 10)^ * d(5e^cos(x)^)/dx - 5e^cos(x)^ * d(tanh^(-1)(x^4^ + 10)^)/dx] / [tanh^(-1)(x^4^ + 10)^]^2^

2. Differentiate each term separately and simplify.
