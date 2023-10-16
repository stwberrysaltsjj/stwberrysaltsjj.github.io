const fileInput = document.getElementById("file-input");
const image = document.getElementById("image");

/**
 * Get the image from file input and display on page
 */
function getImage() {
  // Check if an image has been found in the input
  if (!fileInput.files[0]) throw new Error("Image not found");
  const file = fileInput.files[0];

  // Get the data url form the image
  const reader = new FileReader();

  // When reader is ready display image.
  reader.onload = function (event) {
    image.setAttribute("src", event.target.result);
    document.body.classList.add("image-loaded");
  };

  // Get data url
  reader.readAsDataURL(file);
}

/**
 * When user uploads a new image, display the new image on the webpage
 */
fileInput.addEventListener("change", getImage);
