training_csvs <- paste0("TrainingData/", dir("TrainingData/"))
df <- do.call(rbind,lapply(training_csvs,read.csv))
df <- df[,-1]
set.seed(0)

head(df)
pca <- prcomp(df[, !(names(df) == "Ges_Type")])
var <- pca$sdev^2
temp <- cumsum(var)
proportionVar <- temp / temp[length(temp)]
PCIndex <- 1:length(temp)
plot(PCIndex, proportionVar, type='l')
print(sort(abs(pca$rotation[,1]), decreasing = T))


color = grDevices::colors()[grep('gr(a|e)y', grDevices::colors(), invert = T)]

color = color[sample(1:length(color),length(training_csvs))]
color = rainbow(length(training_csvs))

shuffledDf <- df #[sample(nrow(df)),]
Ges_Types = levels(unique(shuffledDf[,ncol(shuffledDf)]))

PC12Color <- data.frame(pca$x[,1:2])
PC12Color$ColorInt <- shuffledDf[,ncol(shuffledDf)]
PC12Color$Color <- "black"
for (i in 1:length(Ges_Types)) {
  if (Ges_Types[i] == "none") {
    color[i] = "black"
  }
  PC12Color$Color[PC12Color$ColorInt==Ges_Types[i]] <- color[i] 
}

plot(PC12Color$PC1, PC12Color$PC2, col=PC12Color$Color, pch = 16, cex=0.5)
legend("topright",legend=Ges_Types, fill=color)