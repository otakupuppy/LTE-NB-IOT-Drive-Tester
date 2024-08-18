
# Solutions to Mid Trimester Exam

## Question 1: 
Identify the conic, determine the standard equation, center, vertices, foci, and provide a sketch for the equation $$2x^2 + 4y^2 + 8x - 24y + 36 = 0$$.

### Solution:
1. **Identify the Conic**:
    - Given equation:
    
    $$2x^2 + 4y^2 + 8x - 24y + 36 = 0$$
   
    - Dividing the equation by 2:

     $$x^2 + 2y^2 + 4x - 12y + 18 = 0$$
      
    - This is an ellipse.

3. **Convert to Standard Form**:
    - Group terms:

     $$(x^2 + 4x) + (2y^2 - 12y) = -18$$

    - Complete the square:
   
     $$(x + 2)^2 - 4 + 2(y - 3)^2 - 18 = -18$$
   
    - Simplify:

     $$(x + 2)^2 + 2(y - 3)^2 = 40$$

    - Divide by 40:
   
     $$\frac{(x + 2)^2}{40} + \frac{(y - 3)^2}{20} = 1$$
   
    - Standard Form:
      
      $${\frac{(x + 2)^2}{40}} + {\frac{(y - 3)^2}{20}} = 1$$

5. **Key Features**:
    - Center: (-2, 3)
    - Vertices: (-2 ± √40, 3) and (-2, 3 ± √20)
    - Foci: (-2 ± √20, 3)
    - The ellipse has a horizontal major axis.

6. **Sketch**:
    - A sketch would show an ellipse centered at (-2, 3) with the major axis horizontal and vertices at (-2 ± 6.32, 3) and minor vertices at (-2, 3 ± 4.47).

---

## Question 2(a):
Express the following complex number in Cartesian/rectangular form:

$$4e^{\frac{\pi}{2} \left(-2 - \frac{j}{2}\right)}$$

### Solution 2(a):
Given: 

$$4e^{\frac{\pi}{2} \left(-2 - \frac{j}{2}\right)}$$

This can be expanded as:

$$4e^{\left(\frac{\pi}{2}(-2)\right)} \cdot e^{\left(\frac{\pi}{2} \cdot \frac{-j}{2}\right)}$$

Simplifying further:

$$4e^{-\pi} \cdot e^{-\frac{\pi j}{4}}$$

Now, express each component in Cartesian form:

1. **First component:**

   $$e^{-\pi} \text{ is a real number, so } 4e^{-\pi} \text{ remains as is.}$$

2. **Second component using Euler's formula:**

   $$e^{-\frac{\pi j}{4}} = \cos\left(-\frac{\pi}{4}\right) + j\sin\left(-\frac{\pi}{4}\right)$$

   Simplifying the trigonometric values:

   $$\cos\left(-\frac{\pi}{4}\right) = \frac{\sqrt{2}}{2}, \quad \sin\left(-\frac{\pi}{4}\right) = -\frac{\sqrt{2}}{2}$$

   Therefore:

   $$e^{-\frac{\pi j}{4}} = \frac{\sqrt{2}}{2} - j\frac{\sqrt{2}}{2}$$

4. **Combine the results:**

   $$z = 4e^{-\pi} \cdot \left(\frac{\sqrt{2}}{2} - j\frac{\sqrt{2}}{2}\right)$$

   Distribute \( 4e^{-\pi} \):

   $$z = 2\sqrt{2}e^{-\pi} - j2\sqrt{2}e^{-\pi}$$

So, the Cartesian form of the given expression is:

$$z = 2\sqrt{2}e^{-\pi} - j2\sqrt{2}e^{-\pi}$$

---

## Question 2(b): 
Raise the complex number (-3 + j) to the power 6.

### Solution:
1. Convert (-3 + j) to polar form:
    - $$r = √(-3)^2 + 1^2) = √10$$
    - $$θ = tan^{-1}\left(\frac{1}{-3}\right)$$
    - $$z = √10 * e^jθ$$

2. Raise to the power 6:
    - $$z^6 = (√10)^6 * e^{j6θ}$$

3. Convert back to Cartesian form.
    - $$z^6 = 10^3 * e^{j6θ}$$
    - $$z^6 = 10^3(cos6θ + jsin6θ)$$

---

## Question 3:
Find the derivative of the function $$y = 5\left(\frac{tanh^{-1}(x^4 + 10)}{e^{cos(x)}}\right)^3$$

To find the derivative of the function:

$$y = 5\left(\frac{\tanh^{-1}(x^4 + 10)}{e^{\cos(x)}}\right)^3$$

### Solution:

Let's denote:

$$u(x) = \frac{\tanh^{-1}(x^4 + 10)}{e^{\cos(x)}}$$

Thus, the function becomes:

$$y = 5 \cdot [u(x)]^3$$

To differentiate \( y \) with respect to \( x \), we use the chain rule. The derivative of \( y \) with respect to \( x \) is:

$$\frac{dy}{dx} = 5 \cdot 3 \cdot [u(x)]^2 \cdot \frac{du}{dx} = 15 \cdot [u(x)]^2 \cdot \frac{du}{dx}$$


Now, we need to find \( \frac{du}{dx} \), where:

$$u(x) = \frac{\tanh^{-1}(x^4 + 10)}{e^{\cos(x)}}$$

Using the quotient rule for differentiation, we get:

$$\frac{du}{dx} = \frac{v \cdot \frac{d}{dx}[\tanh^{-1}(x^4 + 10)] - u \cdot \frac{d}{dx}[e^{\cos(x)}]}{v^2}$$

Here, 

- \( u = \tanh^{-1}(x^4 + 10) \)
- \( v = e^{\cos(x)} \)

The derivatives are:

1. $$\( \frac{d}{dx}[\tanh^{-1}(x^4 + 10)] = \frac{1}{1 - (x^4 + 10)^2} \cdot \frac{d}{dx}[x^4 + 10] = \frac{4x^3}{1 - (x^4 + 10)^2} \)$$
  
2. $$\( \frac{d}{dx}[e^{\cos(x)}] = -e^{\cos(x)} \cdot \sin(x) \)$$

Substitute these into the quotient rule:

$$\frac{du}{dx} = \frac{e^{\cos(x)} \cdot \frac{4x^3}{1 - (x^4 + 10)^2} - \tanh^{-1}(x^4 + 10) \cdot (-e^{\cos(x)} \cdot \sin(x))}{\left(e^{\cos(x)}\right)^2}$$

Simplifying:

$$\frac{du}{dx} = \frac{4x^3 \cdot e^{\cos(x)}}{e^{2\cos(x)} \cdot (1 - (x^4 + 10)^2)} + \frac{\tanh^{-1}(x^4 + 10) \cdot \sin(x)}{e^{\cos(x)}}$$

Thus, the full derivative \( \frac{dy}{dx} \) is:

$$\frac{dy}{dx} = 15 \cdot \left(\frac{\tanh^{-1}(x^4 + 10)}{e^{\cos(x)}}\right)^2 \cdot \left[\frac{4x^3 \cdot e^{\cos(x)}}{e^{2\cos(x)} \cdot (1 - (x^4 + 10)^2)} + \frac{\tanh^{-1}(x^4 + 10) \cdot \sin(x)}{e^{\cos(x)}}\right]$$
