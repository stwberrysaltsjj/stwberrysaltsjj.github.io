body {
  font-family: "Source Sans Pro", sans-serif;
}

main {
  width: 100%;
  min-height: 100vh;
  display: flex;
  justify-content: center;
  align-items: center;
  flex-direction: column;
}

section {
  margin: 2rem 1rem;
}

.file-group {
  padding: 1rem;
  background: #efefef;
  border-radius: 1rem;
}

#image {
  max-width: 100%;
  width: 400px;
  height: auto;
  display: block;
  margin: auto;
}

.image-section {
  display: none;
  position: relative;
}

.image-loaded .image-section {
  display: block;
} 
.loading .loader {
  display: block;
}

.loader {
  display: none;
}

.loading .image-section,
.loading .file-section {
  display: none;
}
/* Black overlay over the image */
.image-section::before {
  content: "";
  z-index: 2;
  position: absolute;
  height: 100%;
  width: 100%;
  background: linear-gradient(transparent, transparent, #000000);
}

.image-prediction {
  position: absolute;
  bottom: 1rem;
  text-align: center;
  font-size: 18px;
  color: #fff;
  left: 0;
  right: 0;
  z-index: 3;
}
