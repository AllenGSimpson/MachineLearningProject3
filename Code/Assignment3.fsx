//--------------------------------------------------------------------------------------------------------------
//
//  CSCI 447 - Machine Learning
//  Assignment #3, Fall 2019
//  Chris Major, Farshina Nazrul-Shimim, Tysen Radovich, Allen Simpson
//
//  [DESCRIPTION]
//
//--------------------------------------------------------------------------------------------------------------

// MODULES
//--------------------------------------------------------------------------------------------------------------
namespace Project3

    // Load the file names from the same folder
    #load "FeedforwardNet.fsx"
    #load "RBFNet.fsx"

    // Open the modules
    open FeedforwardNet
    open RBFNet

    // Declare as a module
    module Assignment3 = 


// OBJECTS
//--------------------------------------------------------------------------------------------------------------

        // Create a Layer object to represent a layer within the neural network
        type Layer = 
            abstract member nodes           : float32[]                         // Sequence to make up vectors
            abstract member nodeCount       : int                               // Number of nodes in the layer

        // Create a ConnectionMatrix object to represent the connection matrix within the neural network
        type ConnectionMatrix = 
            abstract member weights         : float32[]                         // Sequence of weights within the matrix
            abstract member inputLayer      : Layer                             // Input layer
            abstract member outputLayer     : Layer                             // Output layer


// FUNCTIONS
//--------------------------------------------------------------------------------------------------------------

        // Write out functions


// IMPLEMENTATIONS
//--------------------------------------------------------------------------------------------------------------


//--------------------------------------------------------------------------------------------------------------
// END OF CODE